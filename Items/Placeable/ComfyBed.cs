using System;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SleepMod.Items.Placeable {
    public class ComfyBed : ModItem {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A bed comfy enough to sleep in.");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 20;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 2000;
            item.createTile = TileType<Tiles.ComfyBed>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.Wood, 15);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
