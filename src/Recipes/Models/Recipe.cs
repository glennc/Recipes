using System;
using System.Collections.Generic;

namespace Recipes
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description {get;set;}
        public string Image{get;set;}
        public List<RecipeStep> Steps {get;set;}
    }

    public class AllRecipes
    {
        public IEnumerable<Recipe> Recipes {get;set;}
    }
}