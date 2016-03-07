using Microsoft.AspNetCore.Mvc;

namespace Recipes
{
    public class HomeController : Controller
    {
        private IRecipeRepository _recipes;
        
        public HomeController(IRecipeRepository recipeRepository)
        {
            var s = this.HttpContext;
            _recipes = recipeRepository;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/AddRecipe")]
        public IActionResult AddRecipe()
        {
            return View();
        }

        [HttpPost("/AddRecipe")]
        public IActionResult AddRecipe(Recipe recipe)
        {
            _recipes.AddRecipe(recipe);
            return View();
        }
    }
}