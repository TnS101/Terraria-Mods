using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Draven
{
    public class SpinningAxeBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Spinning Axes!");
            Description.SetDefault("Grants bonus throw damage when an axe is picked up!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.thrownDamage += 0.25f;
        }
    }
}
