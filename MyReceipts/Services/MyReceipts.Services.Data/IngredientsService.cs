namespace MyReceipts.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MyReceipts.Data.Common.Repositories;
    using MyReceipts.Data.Models;
    using MyReceipts.Services.Mapping;

    public class IngredientsService : IIngredientsService
    {
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;

        public IngredientsService(IDeletableEntityRepository<Ingredient> ingredientsRepository)
        {
            this.ingredientsRepository = ingredientsRepository;
        }

        public IEnumerable<T> GetAllPopular<T>()
        {
            return this.ingredientsRepository.All()
                //.Where(x => x.Recipes.Count() >= 10)
                .OrderByDescending(x => x.Recipes.Count)
                .To<T>().ToList();
        }
    }
}
