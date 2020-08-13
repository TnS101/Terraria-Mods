using Terraria;
using Terraria.ModLoader;

namespace CustomMod
{
    public class MainPlayer : ModPlayer
    {
        public MainPlayer()
        {

        }

        public override void OnMissingMana(Item item, int neededMana)
        {
            base.OnMissingMana(item, neededMana);
            item.active = false;
        }
    }
}
