﻿using ExtraExplosives.Projectiles;
using Terraria.ModLoader;

namespace ExtraExplosives.Items.Explosives
{
	public class BulletBoomItemCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BulletBoom [c/AC90FF:(Crystal Bullet)]");
			Tooltip.SetDefault("Who said a gun is the only thing that can shoot a bullet? \n" +
				"Blows up upon touching a block.");
		}

		public override string Texture => "ExtraExplosives/Items/Explosives/BulletBoomItem";

		public override void SetDefaults()
		{
			item.CloneDefaults(ModContent.ItemType<BulletBoomItem>());
			item.damage = 45;	 //The damage stat for the Weapon.
			item.shoot = ModContent.ProjectileType<BulletBoomProjectileCrystal>();//This defines what type of projectile this item will shoot
		}
	}
}