using Terraria.ModLoader;

namespace CustomMod.DeBuffs.Udyr
{
    public class BearStunCD : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Bear Slap CD");
            Description.SetDefault("Cannot be affected by Bear Slap!");
        }
    }
}
