using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class PhoenixStance : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Phoenix Stance");
            Description.SetDefault("Magical crit chance is increased!");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.hairColor = Color.OrangeRed;
            player.hair = 26;
            player.eyeColor = Color.Red;
            player.magicCrit += 6;

            if (!player.HasBuff(mod.BuffType("PhoenixStance")))
            {
                player.hairColor = Color.Brown;
                player.eyeColor = Color.Brown;
                player.hair = 1;
            }
        }
    }
}
