using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Draven
{
    public class BloodRushB : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blood Rush");
            Description.SetDefault("Grants Movement Speed.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.50f;
            player.thrownVelocity += 0.15f;
        }
    }
}
