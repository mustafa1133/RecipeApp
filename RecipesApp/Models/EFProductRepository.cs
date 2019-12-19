using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Models
{
    public class EFProductRepository: IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }



        public IQueryable<Recipe> Recepies => context.Recipes;

        public void SaveProduct(Recipe recipe)
        {
            if (recipe.Id == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe productEntry = context.Recipes
                    .FirstOrDefault(p => p.Id == recipe.Id);

                if (productEntry != null)
                {
                    productEntry.Name = recipe.Name;
                    productEntry.Ingredient1 = recipe.Ingredient1;
                    productEntry.Ingredient2 = recipe.Ingredient2;
                    productEntry.Ingredient3 = recipe.Ingredient3;
                    productEntry.Ingredient4 = recipe.Ingredient4;
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteProduct(int productID)
        {
            Recipe productEntry = context.Recipes
                .FirstOrDefault(p => p.Id == productID);

            if (productEntry != null)
            {
                context.Recipes.Remove(productEntry);
                context.SaveChanges();
            }

            return productEntry;
        }


    }
}
