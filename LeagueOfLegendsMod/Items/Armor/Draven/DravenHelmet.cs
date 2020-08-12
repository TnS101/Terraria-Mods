using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Armor.Draven
{
    [AutoloadEquip(EquipType.Head)]
    public class DravenHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Draven Headgear");
            Tooltip.SetDefault("Absolutelty Awesome! + 8 Defense");
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

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("DravenChest") && legs.type == mod.ItemType("DravenLegs");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Draven is the best!";
            player.statLife += 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.statDefense += 8;
        }
    }
}
