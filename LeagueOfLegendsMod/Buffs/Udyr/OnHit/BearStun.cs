using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class BearStun : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Bear Slap");
            Description.SetDefault("Stunned!");
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (!npc.HasBuff(mod.BuffType("BearStunCD")))
            {
                npc.AddBuff(BuffID.Stoned, 300);
                npc.AddBuff(mod.BuffType("BearStunCD"), 300);
            }
        }
    }
}
