using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class ClothArmor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cloth Armor");
            Tooltip.SetDefault("Grants Bonus Defense.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 3;
        }
    }
}
