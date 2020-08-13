using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Accessories
{
    public class RejuvenationBead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rejuvenation Bead");
            Tooltip.SetDefault("Grants slight Life Regen.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.lifeRegen += 1;
        }
    }
}
