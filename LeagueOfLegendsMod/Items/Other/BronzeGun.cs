using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Other
{
    public class BronzeGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Gun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("An old gun.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.crit = 4;
            item.ranged = true;
            item.useTime = 100;
            item.reuseDelay = 100;
            item.noMelee = true;
            item.ammo = 999;
            item.width = 180;
            item.height = 180;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 10;
            item.rare = 6;
            item.UseSound = SoundID.Item100;
            item.autoReuse = true;
            item.reuseDelay = 100;
            item.shoot = 10; 
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BronzeBar"), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
