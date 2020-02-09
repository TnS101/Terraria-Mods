using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class MonkeysAgility : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Monkey's Agility(1)");
            Description.SetDefault("Movement and Attack Speed are sligthly increased!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.1f;
            player.meleeSpeed += 0.1f;
        }
    }
}
