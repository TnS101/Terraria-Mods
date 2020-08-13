using CustomMod.Buffs.Udyr.OnHit;
using CustomMod.Validators;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Held.Udyr
{
    public class TigerStrike : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tiger Strike");
            Tooltip.SetDefault("Every forth attack deals double damage!");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.damage = 8;
            item.width = 20;
            item.height = 20;
            item.rare = ItemRarityID.Yellow;
            item.knockBack = 3;
            item.useTime = 10;
            item.autoReuse = true;
            item.value = 10;
            item.useAnimation = 32;
            item.UseSound = SoundID.Item100;
            item.crit = 0;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (!player.HasBuff(mod.BuffType("TigerStanceCD")) && !player.HasBuff(mod.BuffType("MonkeyPenalty")))
                {
                    player.AddBuff(mod.BuffType("TigerDoubleDamage"), 800);
                    item.useStyle = ItemUseStyleID.HoldingOut;
                    item.noMelee = true;
                    item.useAnimation = 10;
                    Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Udyr/Item/UdyrTigerStance"));
                    PassiveCheck(player);
                    player.AddBuff(mod.BuffType("TigerStance"), 200);
                    player.AddBuff(mod.BuffType("MonkeyPenalty"), 100);
                    player.AddBuff(mod.BuffType("TigerStanceCD"), new PlayerCDApplier().Execute(player, 350));
                    AttackCounter = 3;
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
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.useAnimation = 32;
            }
            return base.CanUseItem(player);
        }

        public override bool UseItem(Player player)
        {
            SoundCounter++;
            var random = new Random();
            var num = random.Next(0, 5);

            if (SoundCounter == 22)
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Udyr/Item/UdyrTiger{num + 1}"));
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

            if (AttackCounter == 1)
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Udyr/Item/UdyrTigerAttack"));
            }

            if (AttackCounter == 3)
            {
                player.AddBuff(mod.BuffType("TigerDoubleDamage"), 300);
            }

            if (AttackCounter == 4)
            {
                target.AddBuff(mod.BuffType("TigerDoubleDamage"), 120);
                item.UseSound = SoundID.Item100;
                AttackCounter = 0;
            }

            if (AttackCounter == 0)
            {
                if (target.HasBuff(mod.BuffType("TigerDoubleDamage")))
                {
                    target.StrikeNPC(target.lifeMax / 4, 0, 1, false, false, false);
                }
                player.ClearBuff(mod.BuffType("TigerDoubleDamage"));
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
