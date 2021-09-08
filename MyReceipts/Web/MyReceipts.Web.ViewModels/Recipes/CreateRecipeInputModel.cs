
namespace MyReceipts.Web.ViewModels.Recipes
{
    using Microsoft.AspNetCore.Http;
    using MyReceipts.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateRecipeInputModel : BaseRecipeInputModel
    {
        [Range(1, 10)]
        public IEnumerable<IFormFile> Images { get; set; }

        public IEnumerable<RecipeIngredientInputModel> Ingredients { get; set; }
    }
}
