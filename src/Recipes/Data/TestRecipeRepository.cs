using System;
using System.Collections.Generic;
using System.Linq;

namespace Recipes
{
    public class TestRecipeRepository : IRecipeRepository
    {
        List<Recipe> _recipies = new List<Recipe>{new Recipe{
                Id = 1, 
                Name="TestRecipe1", 
                Description="TestRecipe1Description", 
                Image="/images/cookies.jpeg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=1,
                        RecipeId=1,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=2,
                        RecipeId=1,
                        Number=2,
                        Text="Make the thing."
                    }
                }
             },
             new Recipe{
                Id = 2, 
                Name="TestRecipe2", 
                Description="TestRecipe2Description", 
                Image="/images/NZ_Lamington.jpg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=3,
                        RecipeId=2,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=4,
                        RecipeId=2,
                        Number=2,
                        Text="Make the thing."
                    }
                }},
                new Recipe{
                Id = 2, 
                Name="TestRecipe2", 
                Description="TestRecipe2Description", 
                Image="/images/NZ_Lamington.jpg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=3,
                        RecipeId=2,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=4,
                        RecipeId=2,
                        Number=2,
                        Text="Make the thing."
                    }
                }},
                new Recipe{
                Id = 2, 
                Name="TestRecipe2", 
                Description="TestRecipe2Description", 
                Image="/images/NZ_Lamington.jpg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=3,
                        RecipeId=2,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=4,
                        RecipeId=2,
                        Number=2,
                        Text="Make the thing."
                    }
                }},
                new Recipe{
                Id = 2, 
                Name="TestRecipe2", 
                Description="TestRecipe2Description", 
                Image="/images/NZ_Lamington.jpg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=3,
                        RecipeId=2,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=4,
                        RecipeId=2,
                        Number=2,
                        Text="Make the thing."
                    }
                }},
                new Recipe{
                Id = 2, 
                Name="TestRecipe2", 
                Description="TestRecipe2Description", 
                Image="/images/NZ_Lamington.jpg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=3,
                        RecipeId=2,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=4,
                        RecipeId=2,
                        Number=2,
                        Text="Make the thing."
                    }
                }},
                new Recipe{
                Id = 2, 
                Name="TestRecipe2", 
                Description="TestRecipe2Description", 
                Image="/images/NZ_Lamington.jpg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=3,
                        RecipeId=2,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=4,
                        RecipeId=2,
                        Number=2,
                        Text="Make the thing."
                    }
                }},
                new Recipe{
                Id = 2, 
                Name="TestRecipe2", 
                Description="TestRecipe2Description", 
                Image="/images/NZ_Lamington.jpg",
                Steps = new List<RecipeStep>{
                    new RecipeStep{
                        Id=3,
                        RecipeId=2,
                        Number=1,
                        Text="Get the ingredients"
                    },
                    new RecipeStep{
                        Id=4,
                        RecipeId=2,
                        Number=2,
                        Text="Make the thing."
                    }
                }}
             };

        public List<Recipe> GetRecipes()
        {
            return _recipies;
        }
        
        public Recipe GetRecipe(int recipeId)
        {
            return GetRecipes().Single(x=>x.Id==recipeId);
        }

        public void AddRecipe(Recipe recipe)
        {
            _recipies.Add(recipe);
        }
    }
}