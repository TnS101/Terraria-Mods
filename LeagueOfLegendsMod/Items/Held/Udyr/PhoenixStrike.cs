using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Udyr
{
    public class PhoenixStrike : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phoenix Strike"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Every forth attack burns your enemy!");
        }

        public override void SetDefaults()
        {
            item.magic = true;
            item.useStyle = 1;
            item.damage = 8;
            item.width = 20;
            item.height = 20;
            item.rare = 8;
            item.knockBack = 3;
            item.useTime = 10;
            item.autoReuse = true;
            item.value = 10;
            item.useAnimation = 38;
            item.UseSound = SoundID.Item100;
            item.crit = 0;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (!player.HasBuff(mod.BuffType("PhoenixStanceCD")) && !player.HasBuff(mod.BuffType("MonkeyPenalty")))
                {
                    AttackCounter = 3;
                    player.AddBuff(mod.BuffType("PhoenixFlame"), 800);
                    item.useStyle = 5;
                    item.noMelee = true;
                    item.useTime = 1;
                    item.useAnimation = 10;
                    Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Udyr/Item/UdyrPhoenixStance"));
                    PassiveCheck(player);
                    player.AddBuff(mod.BuffType("PhoenixStance"), 200);
                    player.AddBuff(mod.BuffType("MonkeyPenalty"), 100);
                    player.AddBuff(mod.BuffType("PhoenixStanceCD"), 350);
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
                item.useStyle = 1;
                item.useTime = 10;
                item.useAnimation = 38;
            }
            return base.CanUseItem(player);
        }

        public override bool UseItem(Player player)
        {
            SoundCounter++;
            var random = new Random();
            var num = random.Next(0, 5);

            if (SoundCounter == 24)
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Udyr/Item/UdyrPhoenix{num + 1}"));
                SoundCounter = 0;
            }
            return true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            AttackCounter++;
            if (AttackCounter % 3 == 0)
            {
                player.AddBuff(mod.BuffType("PhoenixFlame"), 800);
            }

            if (target.onFire)
            {
                target.life -= 3;
            }

            if (AttackCounter == 4)
            {
                target.AddBuff(BuffID.OnFire, 150);
                player.ClearBuff(mod.BuffType("PhoenixFlame"));
                AttackCounter = 0;
            }
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

        private int AttackCounter = 0;
        private int SoundCounter = 0;
    }
}
