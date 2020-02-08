using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Udyr
{
    public class BearStrike : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bear Strike");
            Tooltip.SetDefault("Stun your target for 1 sec.(4 sec CD)");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.useStyle = 3;
            item.damage = 5;
            item.width = 30;
            item.height = 30;
            item.rare = 8;
            item.knockBack = 1;
            item.useTime = 10;
            item.autoReuse = false;
            item.value = 10;
            item.useAnimation = 30;
            item.UseSound = SoundID.Item100;
            item.crit = 0;
        }

        public override bool UseItem(Player player)
        {
            SoundCounter++;
            var random = new Random();
            var num = random.Next(0, 5);
            
            if (SoundCounter == 13)
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Udyr/Item/UdyrBear{num + 1}"));
                SoundCounter = 0;
            }
            else
            {
                item.UseSound = SoundID.Item100;
            }
            return true;
        }

        public override void OnHitPvp(Player player, Player target, int damage, bool crit)
        {
            AttackCounter++;
            if (!target.HasBuff(mod.BuffType("BearStunCD")))
            {
                target.AddBuff(BuffID.Stoned, 80);
                target.AddBuff(mod.BuffType("BearStunCD"), 300);
            }

            if (AttackCounter == 3)
            {
                AttackCounter = 0;
            }
            else
            {
                player.ClearBuff(mod.BuffType("TigerDoubleDamage"));
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            AttackCounter++;
            if (!target.HasBuff(mod.BuffType("BearStunCD")))
            {
                target.AddBuff(BuffID.Stoned, 80);
                target.AddBuff(mod.BuffType("BearStunCD"), 300);
            }
            if (AttackCounter == 3)
            {
                AttackCounter = 0;
            }
            else
            {
                player.ClearBuff(mod.BuffType("TigerDoubleDamage"));
            }
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (!player.HasBuff(mod.BuffType("BearStanceCD")) && !player.HasBuff(mod.BuffType("MonkeyPenalty")))
                {
                    item.noMelee = true;
                    Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Udyr/Item/UdyrBearStance"));
                    PassiveCheck(player);
                    player.AddBuff(mod.BuffType("BearStance"), 100);
                    player.AddBuff(mod.BuffType("MonkeyPenalty"), 100);
                    player.AddBuff(mod.BuffType("BearStanceCD"), 350);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                item.noMelee = false;
            }
            return base.CanUseItem(player);
        }

        public void PassiveCheck(Player player)
        {
            if (!player.HasBuff(mod.BuffType("MonkeysAgility")) && !player.HasBuff(mod.BuffType("MonkeysAgilityLevel2"))
                && !player.HasBuff(mod.BuffType("MonkeysAgilityLevel3")))
            {
                player.AddBuff(mod.BuffType("MonkeysAgility"), 350);
            }
            else if (player.HasBuff(mod.BuffType("MonkeysAgility")))
            {
                player.ClearBuff(mod.BuffType("MonkeysAgility"));
                player.AddBuff(mod.BuffType("MonkeysAgilityLevel2"), 350);
            }
            else if (player.HasBuff(mod.BuffType("MonkeysAgilityLevel2")))
            {
                player.ClearBuff(mod.BuffType("MonkeysAgilityLevel2"));
                player.AddBuff(mod.BuffType("MonkeysAgilityLevel3"), 350);
            }
            else if (player.HasBuff(mod.BuffType("MonkeysAgilityLevel3")))
            {
                player.AddBuff(mod.BuffType("MonkeysAgilityLevel3"), 350);
            }
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        private int SoundCounter = 0;
        private int AttackCounter = 0;
    }
}
