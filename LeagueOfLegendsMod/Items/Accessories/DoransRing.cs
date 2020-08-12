using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class DoransRing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Doran's Ring");
            Tooltip.SetDefault("Grants Magic Damage,Health and Mana regen.");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.rare = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.15f;
            player.statLifeMax2 += 6;
            player.manaRegenBonus += 2;
        }
    }
}
