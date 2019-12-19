﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RecipesApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if(!context.Recipes.Any())
            {
                context.AddRange(
                    new Recipe
                    {
                        Name="Pizza",
                        Ingredient1="Cheese",
                        Ingredient2="Sauce",
                        Ingredient3="Olives",
                        Ingredient4="Mushrooms"

                    });

                context.SaveChanges();
            }
        }
    }
}
