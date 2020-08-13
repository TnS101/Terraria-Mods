using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Other
{
    public class BronzePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Pickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A shittey pickaxe :(.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.crit = 4;
            item.pick = 50;
            item.width = 120;
            item.height = 120;
            item.useTime = 28;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 10000;
            item.rare = 8;
            item.UseSound = SoundID.Item100;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BronzeBar"), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
