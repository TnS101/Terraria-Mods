using Terraria;
using Terraria.ModLoader;

namespace CustomMod.DeBuffs.Draven
{
    public class BloodRushCD : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blood Rush CD"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Description.SetDefault("Blood Rush is on CD!");
        }

    }
}
