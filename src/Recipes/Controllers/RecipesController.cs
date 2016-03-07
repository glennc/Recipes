using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Recipes
{
    public class RecipesController
    {
        private IRecipeRepository _recipes;

        public RecipesController(IRecipeRepository recipesRepository)
        {
            _recipes = recipesRepository;
            
        }

        [HttpGet("/api/recipes")]
        public AllRecipes GetRecipes()
        {
            var recipes = _recipes.GetRecipes();
            return new AllRecipes{Recipes = recipes};
        }
        
        [HttpGet("/api/recipes/{id}")]
        public Recipe GetRecipes(int id)
        {
            return _recipes.GetRecipe(id);
        }
    }
}