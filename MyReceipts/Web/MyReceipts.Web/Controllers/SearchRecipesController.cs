namespace MyReceipts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyReceipts.Services.Data;
    using MyReceipts.Web.ViewModels.Recipes;
    using MyReceipts.Web.ViewModels.SearchRecipes;

    public class SearchRecipesController : BaseController
    {
        private readonly IRecipeService recipeService;
        private readonly IIngredientsService ingredientsService;

        public SearchRecipesController(
            IRecipeService recipeService,
            IIngredientsService ingredientsService)
        {
            this.recipeService = recipeService;
            this.ingredientsService = ingredientsService;
        }

        public IActionResult Index()
        {
            var viewModel = new SearchIndexViewModel
            {
                Ingredients = this.ingredientsService.GetAllPopular<IngredientNameIdViewModel>(),
            };
            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult List(SearchListInputModel input)
        {
            var viewModel = new ListViewModel
            {
                Recipes = this.recipeService
                .GetByIngredients<RecipeInListViewModel>(input.Ingredients),
            };
            return this.View(viewModel);
        }
    }
}
