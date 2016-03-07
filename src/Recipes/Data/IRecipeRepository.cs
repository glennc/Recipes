using System;
using System.Collections.Generic;

namespace Recipes
{
    public interface IRecipeRepository
    {
        List<Recipe> GetRecipes();
        Recipe GetRecipe(int recipeId);
        void AddRecipe(Recipe recipe);
    }
}