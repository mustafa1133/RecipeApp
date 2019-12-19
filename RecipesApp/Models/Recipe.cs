using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RecipesApp.Models
{
    public class Recipe
    {
        [Required(ErrorMessage = "Please Enter Food Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter an Ingredient")]
        public string Ingredient1 { get; set; }
        [Required(ErrorMessage = "Please Enter an Ingredient")]
        public string Ingredient2 { get; set; }
        [Required(ErrorMessage = "Please Enter an Ingredient")]
        public string Ingredient3 { get; set; }
        [Required(ErrorMessage = "Please Enter an Ingredient")]
        public string Ingredient4 { get; set; }
        [Key]
        public int Id { get; set; }





    }
}
