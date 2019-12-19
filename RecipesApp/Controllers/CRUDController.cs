using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Models;
using Microsoft.AspNetCore.Builder;

namespace RecipesApp.Controllers
{
    public class CRUDController : Controller
    {
        private IProductRepository repository;


        public CRUDController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Recepies );

        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRecipe(Recipe guestResponse)
        {
            repository.SaveProduct(guestResponse);
            // return View("Index", guestResponse);
            return RedirectToAction("Index", "Home", guestResponse);

        }

        public ViewResult Update(int productId) =>
        View(repository.Recepies
        .FirstOrDefault(p => p.Id == productId));

        [HttpPost]
        public IActionResult Update(Recipe product)
        {
            repository.SaveProduct(product);
            TempData["message"] = $"{product.Name} has been saved!";
            return RedirectToAction("RecipeList","Home");

        }

        [HttpPost]
        public IActionResult Delete(int productId)
        {
            Recipe deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted!";
            }


            return RedirectToAction("RecipeList","Home");
        }
    }
}
