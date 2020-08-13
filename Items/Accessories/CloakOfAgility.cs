using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class CloakOfAgility : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("CloakOfAgility");
            Tooltip.SetDefault("Grants a moderate amount of Critical Chance.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 25;
            player.magicCrit += 25;
            player.rangedCrit += 25;
        }
    }
}
