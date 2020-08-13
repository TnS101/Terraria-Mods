using Terraria.ModLoader;

namespace CustomMod.Items.Consumeables.Items
{
    public class HealthPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Health Potion(L)");
            Tooltip.SetDefault("Restores 2 Life per second for 15 seconds.");
        }

        public override void SetDefaults()
        {
            item.consumable = true;
            item.maxStack = 5;
            item.width = 32;
            item.height = 32;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 2;
            item.value = 100;
            item.rare = 10;
            item.useTurn = true;
            item.buffType = mod.BuffType("HealthPotionBuff");
            item.buffTime = 900;
        }
    }
}
