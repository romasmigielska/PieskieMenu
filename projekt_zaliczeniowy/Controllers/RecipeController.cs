using projekt_zaliczeniowy.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using projekt_zaliczeniowy.Data;
using Microsoft.AspNetCore.Identity;

namespace projekt_zaliczeniowy.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private DataContext dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public RecipeController(DataContext dbContext, UserManager<IdentityUser> userManager)
        {
            this.dbContext = dbContext;
            _userManager = userManager;
        }

        // Akcja wyświetlająca formularz wyboru składników karmy
        public async Task<IActionResult> Recipe()
        {
            Recipe recipe = new Recipe();
            var ingredients = await dbContext.Ingredient.Where(a=>a.Definition).ToListAsync();
            ingredients.ForEach(a => a.Definition = false);
            recipe.Ingredients = ingredients;
            return View(recipe);
        }

        // Akcja obsługująca zapis przepisu
        [HttpPost]
        public async Task<ActionResult> SaveRecipe(Recipe recipe)
        {

            //var maxId = dbContext.Ingredient.Max(a => a.Id);
            var ingredients = await dbContext.Ingredient.Where(a => a.Definition).ToListAsync();

            List<Ingredient> newIngridients = new List<Ingredient>();
            foreach (var ingredient in recipe.Ingredients.Where(a=>a.Quantity>0)) 
            {
                var i = ingredients.First(a=>a.Id == ingredient.Id);

                newIngridients.Add(new Ingredient() { 
                    Quantity = ingredient.Quantity,
                    Fat = i.Fat,
                    Protein = i.Protein,
                    Carbohydrates = i.Carbohydrates,
                    Definition = false,
                    Name = i.Name,
                    Description = i.Description
                });
            
            }
            recipe.Ingredients = newIngridients;


            recipe.UserId = Guid.Parse(_userManager.GetUserId(User));
            recipe.Description = "";
            //// Zapisanie przepisu w bazie danych
            dbContext.Recipes.Add(recipe);
            dbContext.SaveChanges();


            return View("recipeSave", recipe);
        }


        public async Task<ActionResult> History()
        {
            // Pobierz listę przepisów (może to być pobranie z bazy danych lub inne źródło danych)
            List<Recipe> recipes = await dbContext.Recipes.ToListAsync();// pobranie listy przepisów

            return View(recipes);
        }

        public ActionResult RecipeShow(int id)
        {
            // Pobierz przepis na podstawie identyfikatora (może to być pobranie z bazy danych lub inne źródło danych)
            Recipe recipe = dbContext.Recipes.Include(a=>a.Ingredients).FirstOrDefault(a => a.Id == id);// pobranie przepisu na podstawie identyfikatora

            if (recipe == null)
            {
                return View(); // Możesz zwrócić odpowiednią stronę błędu, jeśli przepis nie został znaleziony
            }

            return View(recipe);
        }
    }
}
