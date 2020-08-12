using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class BlastingWand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blasting Wand");
            Tooltip.SetDefault("Grants a moderate amount of Magic Damage.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.62f;
        }
    }
}
