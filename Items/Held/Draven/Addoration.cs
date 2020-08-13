namespace CustomMod.Items.Held.Draven
{
    using Terraria;
    using Terraria.ModLoader;

    public class Addoration : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Addoration");
            Tooltip.SetDefault("Welcome to the league of Draaaaven!");
        }

        public override void SetDefaults()
        {
            item.consumable = true;
            item.maxStack = 999;
            item.useStyle = 4;
            item.useTime = 1;
            item.autoReuse = false;
        }

        public override void OnConsumeItem(Player player)
        {
            player.DoCoins(2);
        }
    }
}
