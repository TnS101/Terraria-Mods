﻿using Terraria;
using Terraria.ModLoader;

namespace CustomMod.Buffs.Udyr
{
    public class MonkeysAgilityLevel2 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Monkey's Agility(2)");
            Description.SetDefault("Movement and Attack Speed are fairly increased!");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.2f;
            player.meleeSpeed += 0.2f;
        }
    }
}
