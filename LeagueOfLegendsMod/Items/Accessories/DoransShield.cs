using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class DoransShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doran's Shield");
            Tooltip.SetDefault("Grants Maximum Life and Life Regen.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 10;
            player.lifeRegen += 1;
        }
    }
}
