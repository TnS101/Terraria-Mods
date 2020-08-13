using System.Threading;
using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr.OnHit
{
    public class TigerDoubleDamage : ModBuff
    {
        private int timer;
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Furious Tiger Strike");
            Description.SetDefault("Your next attack will apply a DOT effect!");
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (this.ReApply(npc, 1, buffIndex))
            {
                return;
            }

            if (timer == 0)
            {
                npc.StrikeNPC(npc.lifeMax / 20, 0, 1, false, false, false);
                npc.HitEffect(1);
                timer = 60;
            }

            timer--;
        }

        public override bool ReApply(NPC npc, int time, int buffIndex)
        {
            if (npc.HasBuff(buffIndex))
            {
                return true;
            }

            return false;
        }
    }
}
