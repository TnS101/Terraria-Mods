using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CustomMod.Projectiles.Draven
{
    public class StandAsideP : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodenBoomerang);
            aiType = ProjectileID.WoodenBoomerang;
            projectile.Name = "Spinning Axe";
            projectile.width = 20;
            projectile.height = 20;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.extraUpdates = 1;
            projectile.noDropItem = false;
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2; // projectile sprite faces up
            projectile.rotation = projectile.velocity.ToRotation(); // projectile faces sprite right
            projectile.rotation += 0.4f * projectile.direction;
            projectile.spriteDirection = projectile.direction;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            knockback = 5f;
            target.stepSpeed -= 3;
            ModPlayer player = mod.GetPlayer("MainPlayer");
            player.player.AddBuff(mod.BuffType("StandAsideCD"),300);
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
