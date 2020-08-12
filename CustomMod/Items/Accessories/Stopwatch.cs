using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Items
{
    public class Stopwatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stopwatch");
            Tooltip.SetDefault("Enter an invulnerable stasis!");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.consumable = true;
            item.width = 20;
            item.height = 20;
            item.useStyle = 4;
            item.useAnimation = 15;
            item.useTime = 15;
            item.rare = 8;
            item.buffType = mod.BuffType("StopwatchBuff");
            item.buffTime = 180;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Items/ZhonyaSound");
        }
    }
}
