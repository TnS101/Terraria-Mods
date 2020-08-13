namespace CustomMod.Validators
{
    using System.Linq;
    using Terraria;

    public class PlayerCDApplier
    {
        public PlayerCDApplier()
        {
        }

        public int Execute(Player player, int buffCD)
        {
            int percentageSum = 0;
            int maximumPercentage = 40;
            foreach (var item in player.inventory.Where(i => i.accessory && i.ToolTip.GetLine(0).Contains("CD")))
            {
                if (percentageSum >= maximumPercentage)
                {
                    percentageSum = maximumPercentage;
                    break;
                }

                percentageSum += int.Parse(item.ToolTip.GetLine(0).Split(':')[1].Split(' ')[0]);
            }

            return (100 - percentageSum) * buffCD / 100;
        }
    }
}
