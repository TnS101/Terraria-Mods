using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class DoransBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doran's Blade");
            Tooltip.SetDefault("Grants Physical Damage,Life and Life Steal.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.2f;
            player.rangedDamage += 0.05f;
            player.statLifeMax2 += 8;
            player.lifeSteal += 0.3f;
        }
    }
}
