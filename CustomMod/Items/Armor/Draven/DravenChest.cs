using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace CustomMod.Armor.Draven
{
    public class DravenChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Draven Chest");
            Tooltip.SetDefault("+ 13 Armor");
        }

        public override void SetDefaults()
        {
            item.bodySlot = 10;
            item.defense = 13;
            item.value = 10;
            item.rare = 8;
            item.width = 18;
            item.height = 18;
        }
    }
}
