namespace MyReceipts.Web.ViewModels.SearchRecipes
{
    using MyReceipts.Data.Models;
    using MyReceipts.Services.Mapping;

    public class IngredientNameIdViewModel : IMapFrom<Ingredient>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
