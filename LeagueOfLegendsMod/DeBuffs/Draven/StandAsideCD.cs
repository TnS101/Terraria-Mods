using Terraria;
using Terraria.ModLoader;

namespace CustomMod.DeBuffs.Draven
{
    public class StandAsideCD : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Stand Aside CD"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Description.SetDefault("Stand Aside is on CD!");
        }
    }
}
