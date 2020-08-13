using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr.OnHit
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
