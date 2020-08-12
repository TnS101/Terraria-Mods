using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class NeedlesslyLargeRod : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Needlessly LargeRod");
            Tooltip.SetDefault("Grants a moderate amount of Magic Damage.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.82f;
        }
    }
}
