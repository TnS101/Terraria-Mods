using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class TigerStance : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Tiger Stance");
            Description.SetDefault("Attack speed greatly increased!");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeSpeed += 0.3f;
            player.hairColor = Color.Orange;
            player.hair = 44;
            player.eyeColor = Color.Yellow;
            if (!player.HasBuff(mod.BuffType("TigerStance")))
            {
                player.hairColor = Color.Brown;
                player.eyeColor = Color.Brown;
                player.hair = 1;
            }
        }
    }
}
