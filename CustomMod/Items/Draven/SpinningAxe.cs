using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Draven
{
    public class SpinningAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spinning Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("I got axes.");
        }

        public override void SetDefaults()
        {
            item.damage = 22;
            item.crit = 0;
            item.noMelee = true;
            item.ranged = true;
            item.autoReuse = true;
            item.consumable = true;
            item.maxStack = 2;
            item.width = 20;
            item.height = 20;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 10;
            item.rare = 10;
            item.noUseGraphic = true;
            item.shoot = mod.ProjectileType("SpinningAxeP");
            item.shootSpeed = 6f;
            item.useTurn = true;
            item.UseSound = SoundID.Item50;
        }

        public override bool OnPickup(Player player)
        {
            player.ClearBuff(mod.BuffType("BloodRushCD"));
            player.AddBuff(mod.BuffType("SpinningAxeBuff"),120);
            return true;
        }
        
        public override void OnConsumeItem(Player player)
        {
            var random = new Random();
            AttackCounter++;
            if (AttackCounter == 1)
            {
                int num = random.Next(0, 6);
                item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Draven/Item/DravenAutoAttack{num + 1}");
            }
            else if (AttackCounter == 2)
            {
                int num = random.Next(7, 12);
                item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Draven/Item/DravenAutoAttack{num + 1}");
                AttackCounter = 0;
            }
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (!player.HasBuff(mod.BuffType("BloodRushCD")))
                {
                    item.damage = 11;
                    var random = new Random();
                    int num = random.Next(0, 2);
                    Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Draven/Item/DravenBloodRush{num + 1}"));
                    player.AddBuff(mod.BuffType("BloodRushB"), 60);
                    player.AddBuff(mod.BuffType("BloodRushCD"),300);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                item.noMelee = true;
                item.damage = 22;
            }
            return base.CanUseItem(player);
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        private int AttackCounter = 0;
    }
}
