namespace MyReceipts.Services.Data
{
    using System.Linq;

    using MyReceipts.Data.Common.Repositories;

    using MyReceipts.Data.Models;
    using MyReceipts.Services.Data.Models;
    using MyReceipts.Web.ViewModels.Home;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly IRepository<Image> imagesRepository;
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;

        public GetCountService(
            IDeletableEntityRepository<Category> categoriesRepository,
            IDeletableEntityRepository<Ingredient> ingredientRepository,
            IDeletableEntityRepository<Recipe> recipesRepository,
            IRepository<Image> imgesRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imagesRepository = imgesRepository;
            this.recipesRepository = recipesRepository;
            this.ingredientsRepository = ingredientRepository;
        }

        public CountsDto GetCount()
        {

            var data = new CountsDto
            {
                RecipesCount = this.recipesRepository.All().Count(),
                CategoriesCount = this.categoriesRepository.All().Count(),
                IngredientsCount = this.ingredientsRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
            };

            return data;
        }
    }
}
