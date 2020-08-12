using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Npcs.Store.Buffs
{
    public class HealthPotionBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Healing from Potion");
            Description.SetDefault("Regenerating Life!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 2;
        }
    }
}
