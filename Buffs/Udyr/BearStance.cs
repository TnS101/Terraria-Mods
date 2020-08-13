using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class BearStance : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Bear Stance");
            Description.SetDefault("Your movement speed is greatly increased!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.20f;
            player.hairColor = Color.RoyalBlue;
            player.hair = 23;
            player.eyeColor = Color.LightBlue;
            if (!player.HasBuff(mod.BuffType("BearStance")))
            {
                player.hairColor = Color.Brown;
                player.eyeColor = Color.Brown;
                player.hair = 1;
            }
        }
        
    }
}
