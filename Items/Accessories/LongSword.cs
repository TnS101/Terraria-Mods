using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class LongSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Long Sword");
            Tooltip.SetDefault("Grants Bonus Physical Damage.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.2f;
            player.rangedDamage += 0.05f;
        }
    }
}
