using System;
using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Draven
{
    public class BloodRush : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Rush");
        }

        public override void SetDefaults()
        {
            item.useStyle = 4;
            item.consumable = false;
            item.autoReuse = true;
            item.useTime = 3;
            item.scale = 0.69f;
            item.useAnimation = 5;

            var random = new Random();
            int num = random.Next(0,2);
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Draven/Item/DravenBloodRush{num + 1}");
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("BloodRushB"),60);
            player.AddBuff(mod.BuffType("BloodRushCD"),300);
            return CanUseItem(player);
        }

        public override bool CanUseItem(Player player)
        {
            if (!player.HasBuff(mod.BuffType("BloodRushCD")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
