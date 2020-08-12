using System.Linq;
using Terraria;

namespace CustomMod.Checks
{
    public class CoolDownItemCheck
    {
        public CoolDownItemCheck()
        {

        }

        public int Check(Player player, int buffCD)
        {
            int percentageSum = 0;
            int percentage = 0;
            int maximumPercentage = 40;
            foreach (var item in player.inventory.Where(i => i.accessory && i.ToolTip.GetLine(0).Contains("CD")))
            {
                if (percentageSum <= maximumPercentage)
                {
                    percentage = int.Parse(item.ToolTip.GetLine(0).Split(':')[1].Split(' ')[0]);
                    percentageSum += percentage;
                }
            }
            buffCD = (100 - percentageSum) * buffCD / 100;
            return buffCD;
        }
    }
}
