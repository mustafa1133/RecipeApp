using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Models
{
    public static class Repository
    { 
        private static List<Recipe> responses = new List<Recipe>();

    public static IEnumerable<Recipe> Responseses
    {
        get
        {
            return responses;
        }


    }

    public static void AddResponse(Recipe response)
    {
            responses.Add(response);

    }

}
}
