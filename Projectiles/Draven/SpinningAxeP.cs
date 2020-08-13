using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Projectiles.Draven
{
    public class SpinningAxeP : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bananarang);
            aiType = 3;
            projectile.Name = "Spinning Axe";
            projectile.damage = 60;
            projectile.width = 20;
            projectile.height = 20;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.extraUpdates = 1;
            projectile.timeLeft = 600;
        }

        public override void Kill(int timeLeft)
        {
            if (Main.myPlayer == projectile.owner)
            {
                var item = Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType("SpinningAxe"), 1, false, 0, false, false);
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            var random = new Random();
            int num = random.Next(0, 2);
            target.DeathSound = mod.GetLegacySoundSlot(SoundType.Custom, $"Sounds/Draven/Item/DravenPassive{num + 1}");

            if (target.life < 1)
            {
                for (int i = 0; i <= 1; i++)
                {
                    var coin = Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, ItemID.SilverCoin, 1, false, 0, false, false);
                }
            }
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 50f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;    // projectile fall velocity
                projectile.velocity.X = projectile.velocity.X * 0.99f;    // projectile velocity
            }
        }
    }
}
