using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class SapphireCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SaphireCrystall");
            Tooltip.SetDefault("Grants bonus Maximum Mana.");
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
