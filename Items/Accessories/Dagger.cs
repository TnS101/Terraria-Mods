using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class Dagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dagger");
            Tooltip.SetDefault("Grants a slight amount of Attack Speed.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.08f;
            player.HeldItem.useTime -= (int)0.08f;
        }
    }
}
