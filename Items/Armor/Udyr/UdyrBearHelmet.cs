using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Items.Armor.Udyr
{
    [AutoloadEquip(EquipType.Head)]
    public class UdyrBearHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Udyr Bear Helmet");
            Tooltip.SetDefault("Wild!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10;
            item.defense = 8;
            item.rare = 8;
        }

        public override bool DrawHead()
        {
            return true;
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 5;
        }
    }
}
