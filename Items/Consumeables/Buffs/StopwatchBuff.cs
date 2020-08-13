using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Consumeables.Buffs
{
    public class StopwatchBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Golden Stasis");
            Description.SetDefault("Immune to Damage!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.immune = true;
            player.AddBuff(BuffID.Stoned, 1);
        }
    }
}
