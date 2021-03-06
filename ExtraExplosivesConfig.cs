using ExtraExplosives.Projectiles;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Config;

namespace ExtraExplosives
{
	public class ExtraExplosivesConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;
		public override void OnLoaded() => ExtraExplosives.EEConfig = this;
		
		[DefaultValue(typeof(Vector2), "-300, -50")]
		[Range(-1920f, 0f)]
		[Label("$Mods.ExtraExplosives.ExtraExplosivesConfig.Label.AnarchistCookbookPos")]
		[Tooltip("$Mods.ExtraExplosives.ExtraExplosivesConfig.Tooltip.AnarchistCookbookPos")]
		public Vector2 AnarchistCookbookPos { get; set; }
		
		public override void OnChanged()
		{
			base.OnChanged();
		}
	}	
	
	[Label("$Mods.ExtraExplosives.ExtraExplosivesConfigs.Title.ExtraExplosivesServerConfig")]
	public class ExtraExplosivesServerConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide; //Change to client to make it only applicable to the client side

		[Header("Explosives Wall Settings")]
		[Label("Toggle Wall Breaking")]
		[DefaultValue(true)]
		public bool CanBreakWalls;

		[Header("Explosives Block Settings")]
		[Label("Toggle Block Breaking for the C4, Da Bomb, and Captain Explosive")]
		[DefaultValue(true)]
		public bool CanBreakTiles;

		[Header("Explosives Dust/Particle Settings")]
		[Label("Set Dust/Particle amount; Current Amount")]
		[Tooltip("0 = No Dust; 1 = Lots of Dust")]
		[Increment(0.1f)]
		[Range(0f, 1f)]
		[DefaultValue(1f)]
		[Slider]
		public float dustAmount;

		public override void OnChanged()
		{
			GlobalMethods.CanBreakWalls = CanBreakWalls;
			GlobalMethods.CanBreakTiles = CanBreakTiles;
			GlobalMethods.DustAmount = dustAmount;

			TheLevelerProjectile.CanBreakWalls = CanBreakWalls;
			//SmallExplosiveProjectile.CanBreakWalls = CanBreakWalls;
			//ArenaBuilderProjectile.CanBreakWalls = CanBreakWalls;
			PhaseBombProjectile.CanBreakWalls = CanBreakWalls;
			//MegaExplosiveProjectile.CanBreakWalls = CanBreakWalls;
			//MediumExplosiveProjectile.CanBreakWalls = CanBreakWalls;
			//LargeExplosiveProjectile.CanBreakWalls = CanBreakWalls;
			//HeavyBombProjectile.CanBreakWalls = CanBreakWalls;
			//GiganticExplosiveProjectile.CanBreakWalls = CanBreakWalls;
			//DaBombProjectile.CanBreakWalls = CanBreakWalls;
			//ClusterBombChildProjectile.CanBreakWalls = CanBreakWalls;
			//ClusterBombProjectile.CanBreakWalls = CanBreakWalls;
			//C4Projectile.CanBreakWalls = CanBreakWalls;
			//BigBouncyDynamiteProjectile.CanBreakWalls = CanBreakWalls;
			//BasicExplosiveProjectile.CanBreakWalls = CanBreakWalls;
			//C4Projectile.CanBreakTiles = CanBreakTiles;
			//DaBombProjectile.CanBreakTiles = CanBreakTiles;
			ExtraExplosives.dustAmount = dustAmount;
		}
	}
}