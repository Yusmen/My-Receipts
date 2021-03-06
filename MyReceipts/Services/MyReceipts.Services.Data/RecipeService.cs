namespace MyReceipts.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using System.Threading.Tasks;

    using MyReceipts.Data.Common.Repositories;
    using MyReceipts.Data.Models;
    using MyReceipts.Services.Mapping;
    using MyReceipts.Web.ViewModels.Recipes;

    public class RecipeService : IRecipeService
    {
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;
        private readonly string[] allowedextensions = new[] { "jpg", "png", "gif" };


        public RecipeService(
            IDeletableEntityRepository<Recipe> recipesRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository)
        {
            this.recipesRepository = recipesRepository;
            this.ingredientsRepository = ingredientsRepository;

        }

        public async Task CreateAsync(CreateRecipeInputModel input, string userId, string imagePath)
        {
            var recipe = new Recipe();

            recipe.CetegoryId = input.CetegoryId;
            recipe.CookingTime = TimeSpan.FromMinutes(input.CookingTime);
            recipe.Instructions = input.Instructions;
            recipe.Name = input.Name;
            recipe.PeparationTime = TimeSpan.FromMinutes(input.PeparationTime);
            recipe.PortionCount = input.PortionCount;
            recipe.AddedByUserId = userId;
            await this.recipesRepository.AddAsync(recipe);

            foreach (var inputIngredient in input.Ingredients)
            {
                var ingredient = this.ingredientsRepository
                    .All()
                    .FirstOrDefault(x => x.Name == inputIngredient.IngredientName);

                if (ingredient == null)
                {
                    ingredient = new Ingredient { Name = inputIngredient.IngredientName };
                }

                recipe.Ingredients.Add(new RecipeIngredient
                {
                    Ingredient = ingredient,
                    Quantity = inputIngredient.Quantity,
                });
            }



            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');

                if (!this.allowedextensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    AddedbyUserId = userId,
                    Extension = Path.GetExtension(image.FileName),
                };
                recipe.Images.Add(dbImage);

                Directory.CreateDirectory($"{imagePath}/recipes");
                var physicalPath = $"{imagePath}wwwroot/images/recipes/{dbImage.Id}.{extension}";

                using (Stream fileStream = new FileStream(physicalPath, FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }
            }

            await this.recipesRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var recipe = this.recipesRepository.All().FirstOrDefault(x => x.Id == id);
            this.recipesRepository.Delete(recipe);
            await this.recipesRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var recipes = this.recipesRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<T>()
                .ToList();

            return recipes;
        }

        public T GetById<T>(int id)
        {
            var recipe = this.recipesRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();

            return recipe;
        }

        public IEnumerable<T> GetByIngredients<T>(IEnumerable<int> ingredientIds)
        {
            var query = this.recipesRepository.All().AsQueryable();
            foreach (var ingredientId in ingredientIds)
            {
                query = query.Where(x => x.Ingredients.Any(i => i.IngeredientId == ingredientId));
            }

            return query.To<T>().ToList();
        }

        public int GetCount()
        {
            return this.recipesRepository.All().Count();
        }

        public IEnumerable<T> GetRandom<T>(int count)
        {
            return this.recipesRepository
                .All()
                .OrderBy(x => Guid.NewGuid())
                .Take(count)
                .To<T>()
                .ToList();
        }

        public async Task UpdateAsync(int id, EditRecipeInputModel input)
        {
            var recipes = this.recipesRepository.All()
                .FirstOrDefault(x => x.Id == id);
            recipes.Name = input.Name;
            recipes.Instructions = input.Instructions;
            recipes.CookingTime = TimeSpan.FromMinutes(input.CookingTime);
            recipes.PeparationTime = TimeSpan.FromMinutes(input.PeparationTime);
            recipes.PortionCount = input.PortionCount;
            recipes.CetegoryId = input.CetegoryId;
            await this.recipesRepository.SaveChangesAsync();
        }
    }
}
