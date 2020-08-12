using Terraria.ModLoader;

namespace CustomMod.DeBuffs.Udyr
{
    public class MonkeyPenalty : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Martial Exhaustion.");
            Description.SetDefault("Cannot switch stances!");
        }
    }
}
