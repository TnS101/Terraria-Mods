using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class TurtleStance : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Turtle Stance");
            Description.SetDefault("Your defense is fairly increased!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 8;
            player.hairColor = Color.DarkSeaGreen;
            player.hair = 24;
            player.eyeColor = Color.LightSeaGreen;
            
            if (!player.HasBuff(mod.BuffType("TurtleStance")))
            {
                player.hairColor = Color.Brown;
                player.eyeColor = Color.Brown;
                player.hair = 1;
            }
        }

        
    }
}
