using CustomMod.Validators;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Held.Udyr
{
    public class TurtleStrike : ModItem
    {
        private int AttackCounter = 0;
        private int SoundCounter = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Turtle Strike");
            Tooltip.SetDefault("Every forth attack heals you!");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.useStyle = 3;
            item.damage = 7;
            item.width = 20;
            item.height = 20;
            item.rare = 8;
            item.knockBack = 8;
            item.useTime = 35;
            item.autoReuse = true;
            item.value = 10;
            item.useAnimation = 35;
            item.UseSound = SoundID.Item100;
            item.scale -= 0.3f;
            item.crit = 0;
        }

        public override bool UseItem(Player player)
        {
            SoundCounter++;
            var random = new Random();
            var num = random.Next(0, 5);
            if (SoundCounter == 15)
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Udyr/Item/UdyrTurtle{num + 1}"));
                SoundCounter = 0;
            }
            else
            {
                item.UseSound = SoundID.Item100;
            }
            return true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            AttackCounter++;
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Udyr/Item/UdyrTurtleAttack"));
            if (AttackCounter % 3 == 0)
            {
                player.AddBuff(mod.BuffType("TurtleHeal"), 800);
            }
            if (AttackCounter == 4)
            {
                player.HealEffect(player.statLifeMax / 20);
                player.statLife += player.statLifeMax / 20;
                player.ClearBuff(mod.BuffType("TurtleHeal"));
                AttackCounter = 0;
            }
            else
            {
                player.ClearBuff(mod.BuffType("TigerDoubleDamage"));
            }
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (!player.HasBuff(mod.BuffType("TurtleStanceCD")) && !player.HasBuff(mod.BuffType("MonkeyPenalty")))
                {
                    int buffCD = 350;
                    AttackCounter = 3;
                    player.AddBuff(mod.BuffType("TurtleHeal"), 800);
                    item.noMelee = true;
                    Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Udyr/Item/UdyrTurtleStance"));
                    PassiveCheck(player);
                    player.AddBuff(mod.BuffType("TurtleStance"), 250);
                    player.AddBuff(mod.BuffType("MonkeyPenalty"), 100);
                    player.AddBuff(mod.BuffType("TurtleStanceCD"), new PlayerCDApplier().Execute(player, buffCD));
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

        
    }
}
