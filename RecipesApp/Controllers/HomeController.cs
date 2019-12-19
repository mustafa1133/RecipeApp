using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Models;
using Microsoft.AspNetCore.Builder;

namespace RecipesApp.Controllers
{
    public class HomeController:Controller
    {
        private IProductRepository repository;


        public HomeController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View();
        }




        public ViewResult RecipeList()
        {
            return View(repository.Recepies);
        }

        public ViewResult ViewRecipe(int id)
        {
            return View(repository.Recepies.Where(r => r.Id == id ));
        }

    }
}