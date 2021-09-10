namespace MyReceipts.Web.ViewModels.SearchRecipes
{
    using System.Collections.Generic;

    using MyReceipts.Web.ViewModels.Recipes;

    public class ListViewModel
    {

        public IEnumerable<RecipeInListViewModel> Recipes { get; set; }

    }
}
