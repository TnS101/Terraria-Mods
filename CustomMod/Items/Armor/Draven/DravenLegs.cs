using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace CustomMod.Armor.Draven
{
    public class DravenLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Draven Legs");
            Tooltip.SetDefault("+ 8 Armor");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.legSlot = 0;
            item.height = 34;
            item.value = 10;
            item.defense = 8;
            item.rare = 8;
        }
    }
}
