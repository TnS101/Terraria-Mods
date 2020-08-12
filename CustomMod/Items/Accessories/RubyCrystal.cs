using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class RubyCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruby Crystal");
            Tooltip.SetDefault("Grants bonus Maximum Life.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 15;
        }
    }
}
