using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class Sheen : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sheen");
            Tooltip.SetDefault("Grants Bonus Mana and reduces Ability CD by:40 percent.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 25;
        }
    }
}
