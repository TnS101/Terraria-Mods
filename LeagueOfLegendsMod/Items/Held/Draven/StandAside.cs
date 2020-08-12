using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Items.Draven
{
    public class StandAside : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stand Aside");
        }

        public override void SetDefaults()
        {
            item.damage = 1;
            item.noMelee = true;
            item.thrown = true;
            item.autoReuse = true;
            item.width = 20;
            item.height = 20;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 13;
            item.value = 10;
            item.rare = 10;
            item.noUseGraphic = true;
            item.shoot = mod.ProjectileType("StandAsideP");
            item.shootSpeed = 5f;
            item.useTurn = true;
            item.UseSound = SoundID.Item100;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(mod.BuffType("StandAsideCD")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
