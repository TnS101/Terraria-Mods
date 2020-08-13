using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class AmplifyingTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amplifying Tome");
            Tooltip.SetDefault("Grants 2 Magiccal Damage.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.3f;
        }
    }
}
