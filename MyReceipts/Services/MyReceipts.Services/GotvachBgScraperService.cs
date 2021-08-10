namespace MyReceipts.Services
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    using AngleSharp;
    using MyReceipts.Data.Common.Repositories;
    using MyReceipts.Data.Models;
    using MyReceipts.Services.Models;

    public class GotvachBgScraperService : IGotvachBgScraperService
    {
        private readonly IConfiguration config;
        private readonly IBrowsingContext context;
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IRepository<Image> imagesRepository;
        private readonly IRepository<RecipeIngredient> recipeIngredientsRepository;

        public GotvachBgScraperService(
            IDeletableEntityRepository<Category> categoryRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository,
            IDeletableEntityRepository<Recipe> recipesRepository,
            IRepository<RecipeIngredient> recipeIngredientsRepository,
            IRepository<Image> imageRepository)
        {
            this.categoriesRepository = categoryRepository;
            this.ingredientsRepository = ingredientsRepository;
            this.recipesRepository = recipesRepository;
            this.recipeIngredientsRepository = recipeIngredientsRepository;
            this.imagesRepository = imageRepository;
            this.config = Configuration.Default.WithDefaultLoader();
            this.context = BrowsingContext.New(this.config);
        }

        public async Task PopulateDbWithRecipesAsync(int recipesCount)
        {
            var concurentBag = new ConcurrentBag<RecipeDto>();
            Parallel.For(1, recipesCount, (i) =>
            {
                try
                {
                    var recipe = this.GetRecipe(i);
                    concurentBag.Add(recipe);
                }
                catch (Exception) { }
            });

            foreach (var recipe in concurentBag)
            {
                var categoryId = await this.GetOrCreateCategoryAsync(recipe.CategoryName);

                // var ingredientsIds = await this.GetOrCreateIngredientAsync(recipe.IngredientNames);
                var recipeExists = this.recipesRepository
                    .AllAsNoTracking()
                    .Any(x => x.Name == recipe.RecipeName);

                if (recipeExists)
                {
                    continue;
                }

                var newRecipe = new Recipe()
                {
                    Name = recipe.RecipeName,
                    Instructions = recipe.Instructions,
                    PeparationTime = recipe.PeparationTime,
                    CookingTime = recipe.CookingTime,
                    PortionCount = recipe.PortionsCount,
                    OriginalUrl = recipe.OriginalUrl,
                    CetegoryId = categoryId, // not sure
                };
                await this.recipesRepository.AddAsync(newRecipe);
                await this.recipesRepository.SaveChangesAsync();
                foreach (var item in recipe.Ingredients)
                {
                    var ingr = item.Split(" - ", 2);

                    if (ingr.Length < 2)
                    {
                        continue;
                    }

                    var ingredientId = await this.GetOrCreateIngredientAsync(ingr[0].Trim());

                    // var qty = string.Join(string.Empty, ingr.Skip(1)).Trim();
                    var qty = ingr[1].Trim();

                    var recipeIngredient = new RecipeIngredient
                    {
                        IngeredientId = ingredientId,
                        RecipeId = newRecipe.Id,
                        Quantity = qty,
                    };

                    await this.recipeIngredientsRepository.AddAsync(recipeIngredient);
                    await this.recipeIngredientsRepository.SaveChangesAsync();
                }

                var image = new Image
                {
                    Extension = recipe.OriginalUrl,
                    RecipeId = newRecipe.Id,
                };
                await this.imagesRepository.AddAsync(image);
                await this.imagesRepository.SaveChangesAsync();
            }

            await this.categoriesRepository.SaveChangesAsync();
            await this.recipesRepository.SaveChangesAsync();
            await this.ingredientsRepository.SaveChangesAsync();
            await this.recipeIngredientsRepository.SaveChangesAsync();
            await this.imagesRepository.SaveChangesAsync();
        }

        private async Task<int> GetOrCreateIngredientAsync(string name)
        {
            var ingredient = this.ingredientsRepository
                   .AllAsNoTracking()
                   .FirstOrDefault(x => x.Name == name);

            if (ingredient == null)
            {
                ingredient = new Ingredient
                {
                    Name = name,
                };
                await this.ingredientsRepository.AddAsync(ingredient);
                await this.ingredientsRepository.SaveChangesAsync();
            }

            return ingredient.Id;
        }

        private async Task<int> GetOrCreateCategoryAsync(string categoryName)
        {
            var category = this.categoriesRepository
                                .AllAsNoTracking()
                                .FirstOrDefault(x => x.Name == categoryName);

            if (category == null)
            {
                category = new Category()
                {
                    Name = categoryName,
                };

                await this.categoriesRepository.AddAsync(category);
                await this.categoriesRepository.SaveChangesAsync();
            }

            return category.Id;
        }

        private RecipeDto GetRecipe(int id)
        {
            var document = this.context.OpenAsync("https://recepti.gotvach.bg/r-{id}")
                .GetAwaiter()
                .GetResult();

            if (document.StatusCode == HttpStatusCode.NotFound
                || document.DocumentElement.OuterHtml.Contains("Тази страница не е намерена."))
            {
                throw new InvalidOperationException();
            }

            var recipe = new RecipeDto();

            // Get category name
            var recipeNameAngCategory = document.QuerySelectorAll("#recEntity > div.breadcrumb")
                .Select(x => x.TextContent)
                .FirstOrDefault()
                .Split(" >>", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            recipe.CategoryName = recipeNameAngCategory[1];
            recipe.RecipeName = recipeNameAngCategory[0].TrimStart();

            // Get instructions
            var instructions = document.QuerySelectorAll(".text > p")
                .Select(x => x.TextContent)
                .ToList();

            var sb = new StringBuilder();

            foreach (var item in instructions)
            {
                sb.AppendLine(item);
            }

            recipe.Instructions = sb.ToString().TrimEnd();

            var timing = document.QuerySelectorAll(".mbox");

            // Get preparation time
            if (timing.Length > 0)
            {
                var preparationTime = timing[0]
               .TextContent
               .Replace("Приготвяне", string.Empty)
               .Replace(" мин ", string.Empty);

                recipe.PeparationTime = TimeSpan.ParseExact(preparationTime, "mm", CultureInfo.InvariantCulture);
            }

            // Get cooking time
            if (timing.Length > 1)
            {
                var cookingTime = timing[1]
               .TextContent
               .Replace("Приготвяне", string.Empty)
               .Replace(" мин ", string.Empty);

                recipe.CookingTime = TimeSpan.ParseExact(cookingTime, "mm", CultureInfo.InvariantCulture);
            }

            // Get portions count
            var portionsCount = document.QuerySelectorAll(".mbox > .feat")
                .LastOrDefault()
                .TextContent;
            recipe.PortionsCount = int.Parse(portionsCount);

            // Get image url
            recipe.OriginalUrl = document.QuerySelector("#newsGal > div.image > img").GetAttribute("src");

            // Get ingredients
            var ingredients = document.QuerySelectorAll("body > section > ul > li");
            foreach (var item in ingredients)
            {
                recipe.Ingredients.Add(item.TextContent);
            }

            return recipe;
        }
    }
}
