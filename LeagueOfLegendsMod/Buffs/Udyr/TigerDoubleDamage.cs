using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class TigerDoubleDamage : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Furious Tiger Strike");
            Description.SetDefault("Your next attack deals double damage!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage *= 2;
        }
    }
}
