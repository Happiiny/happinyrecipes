using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace happinymod
{
    public class happinymod : Mod
    {
        public happinymod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
		
		public override void AddRecipeGroups() {

            RecipeGroup gold = new RecipeGroup(() => Lang.misc[37] + " Gold Bar", new int[] 
            {
				ItemID.GoldBar,
				ItemID.PlatinumBar,
			});
			RecipeGroup.RegisterGroup("happinymod:GoldBars", gold);
						
            RecipeGroup silver = new RecipeGroup(() => Lang.misc[37] + " Silver Bar", new int[] 
            {
				ItemID.SilverBar,
				ItemID.TungstenBar,
			});
            RecipeGroup.RegisterGroup("happinymod:SilverBars", silver);
        }

        public override void AddRecipes()
        {
            //Anklet of the Wind
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(210, 3); //Vine
			recipe.AddIngredient(331, 8); //Spore
			recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(212); //Anklet
            recipe.AddRecipe();
			
			//Hermes Boots
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.GreenThread, 1);
			recipe.AddIngredient(ItemID.Cloud, 5);
			recipe.AddIngredient(ItemID.Feather, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HermesBoots);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.GreenDye, 1);
			recipe.AddIngredient(ItemID.Cloud, 5);
			recipe.AddIngredient(ItemID.Feather, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HermesBoots);
			recipe.AddRecipe();
			
			//Ice Skates
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.SilverBar, 8);
			recipe.AddIngredient(ItemID.Shiverthorn, 3);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();
			
			//Lava Charm
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.ObsidianSkinPotion);
			recipe.AddIngredient(ItemID.Obsidian, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LavaCharm);
			recipe.AddRecipe();
			
			//Balloon
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 20);
			recipe.AddIngredient(ItemID.WhiteString);
			recipe.AddIngredient(ItemID.RedDye);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.ShinyRedBalloon);
			recipe.AddRecipe();
			
			//Horseshoe
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddIngredient(ItemID.Feather, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 8);
			recipe.AddIngredient(ItemID.Feather, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();
			
			//Water Walking Boots
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HermesBoots);
			recipe.AddIngredient(ItemID.Coral, 3);
			recipe.AddIngredient(ItemID.WaterWalkingPotion, 3);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.WaterWalkingBoots);
			recipe.AddRecipe();
			
			//Band of Regeneration 
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.SilverBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofRegeneration);
			recipe.AddRecipe();
			
			//Band of Starpower
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BandofRegeneration);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.DemoniteBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofStarpower);
			recipe.AddRecipe();
			
			//Magic Mirror
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SilverBar, 20);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();
			
			//Celestial Magnet
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SilverBar, 15);
			recipe.AddIngredient(ItemID.ManaCrystal, 6);
			recipe.AddIngredient(ItemID.Diamond, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CelestialMagnet);
			recipe.AddRecipe();
			
			//Feral Claws
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Vine, 3);
			recipe.AddIngredient(331, 12);
			recipe.AddIngredient(ItemID.Stinger, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FeralClaws);
			recipe.AddRecipe();
			
			//Cobalt Shield
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddRecipeGroup("happinymod:SilverBars", 10);
			recipe.AddRecipeGroup("happinymod:GoldBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.AddRecipeGroup("happinymod:SilverBars", 10);
			recipe.AddRecipeGroup("happinymod:GoldBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.AncientCobaltHelmet);
			recipe.AddRecipeGroup("happinymod:SilverBars", 10);
			recipe.AddRecipeGroup("happinymod:GoldBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.AncientCobaltLeggings);
			recipe.AddRecipeGroup("happinymod:SilverBars", 10);
			recipe.AddRecipeGroup("happinymod:GoldBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.AncientCobaltBreastplate);
			recipe.AddRecipeGroup("happinymod:SilverBars", 10);
			recipe.AddRecipeGroup("happinymod:GoldBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();
			
			//Frozen Turtle Shell
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TurtleShell, 2);
			recipe.AddIngredient(ItemID.FrostCore);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FrozenTurtleShell);
			recipe.AddRecipe();
			
			//Magma Stone
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Hellstone, 30);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MagmaStone);
			recipe.AddRecipe();
			
			//Panic Necklace
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PanicNecklace);
			recipe.AddRecipe();
			
			//Brain --> Scarf
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.WormScarf);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BrainOfConfusion);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BrainOfConfusion);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WormScarf);
			recipe.AddRecipe();
			
			//Jellyfish Necklace
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Glowstick, 20);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddIngredient(ItemID.Coral, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.JellyfishNecklace);
			recipe.AddRecipe();
			
			//Neptune's Shell
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofFright, 20);
			recipe.AddIngredient(ItemID.Coral, 15);
			recipe.AddIngredient(ItemID.Goldfish, 15);
			recipe.AddIngredient(ItemID.SharkFin, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.NeptunesShell);
			recipe.AddRecipe();
			
			//Slime Staff
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.anyWood = true;
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SlimeStaff);
			recipe.AddRecipe();
			
						//Cloud in a bottle
                        recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddIngredient(ItemID.Cloud, 50);
			recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.Feather, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.CloudinaBottle);
			recipe.AddRecipe();

                        //Blizzard in a bottle
                        recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CloudinaBottle);
			recipe.AddIngredient(ItemID.IceBlock, 50);
			recipe.AddIngredient(ItemID.SnowBlock, 100);
            recipe.AddIngredient(ItemID.Slush, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.BlizzardinaBottle);
			recipe.AddRecipe();

                        //Sandstorm in a bottle
                        recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CloudinaBottle);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
            recipe.AddIngredient(ItemID.HardenedFossil, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SandstorminaBottle);
			recipe.AddRecipe();
        }
    }
}
