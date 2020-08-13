using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr.OnHit
{
    public class PhoenixFlame : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Phoenix Flame");
            Description.SetDefault("Your next attack will  burn your enemy!" +
                "(If you target is on fire you deal bonus damage with your basic attacks!)");
        }
    }
}
