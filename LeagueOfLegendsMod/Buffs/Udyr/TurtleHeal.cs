using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class TurtleHeal : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Healing Turtle");
            Description.SetDefault("Your next attack will heal you!");
        }
    }
}
