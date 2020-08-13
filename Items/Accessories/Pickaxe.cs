using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class Pickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pickaxe");
            Tooltip.SetDefault("Grants a moderate amount of Physical Damage.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.48f;
            player.rangedDamage += 0.15f;
        }
    }
}
