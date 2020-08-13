using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Other
{
    public class BronzeBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A good Bar.");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = 10000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.CopperOre, 1);
            recipe.SetResult(this);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddRecipe();
        }
    }
}
