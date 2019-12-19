using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Models
{
    public interface IProductRepository
    {

        IQueryable<Recipe> Recepies { get; }
        void SaveProduct(Recipe recipe);

        Recipe DeleteProduct(int productId);
    }
}
