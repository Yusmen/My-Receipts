namespace MyReceipts.Web.ViewModels.Recipes
{
    using MyReceipts.Data.Models;
    using MyReceipts.Services.Mapping;

    public class IngredientsViewModel : IMapFrom<RecipeIngredient>
    {
        public string Quantity { get; set; }

        public string IngredientName { get; set; }
    }
}
