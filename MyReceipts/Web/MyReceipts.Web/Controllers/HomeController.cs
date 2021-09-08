namespace MyReceipts.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using MyReceipts.Services.Data;
    using MyReceipts.Web.ViewModels;
    using MyReceipts.Web.ViewModels.Home;

    using System.Diagnostics;

    using System.Linq;

    public class HomeController : BaseController
    {
        private readonly IGetCountService countService;
        private readonly IRecipeService recipesService;

        public HomeController(
            IGetCountService countService,
            IRecipeService recipesService)
        {
            this.countService = countService;
            this.recipesService = recipesService;
        }

        public IActionResult Index()
        {
            var countsDto = this.countService.GetCount();
            var viewModel = new IndexViewModel
            {
                CategoriesCount = countsDto.CategoriesCount,
                IngredientsCount = countsDto.IngredientsCount,
                ImagesCount = countsDto.ImagesCount,
                RecipesCount = countsDto.RecipesCount,
                RandomRecipes = this.recipesService.GetRandom<IndexPageRecipeViewModel>(10),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
