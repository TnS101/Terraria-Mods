using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class MonkeysAgilityLevel3 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Monkey's Agility(3)");
            Description.SetDefault("Movement and Attack Speed are greatly increased!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.3f;
            player.meleeSpeed += 0.3f;
        }
    }
}
