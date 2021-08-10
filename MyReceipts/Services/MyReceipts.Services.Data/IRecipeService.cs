namespace MyReceipts.Services.Data
{
    
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MyReceipts.Web.ViewModels.Recipes;

    public interface IRecipeService
    {
        Task CreateAsync(CreateRecipeInputModel input, string userId, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPage = 12);

        int GetCount();
    }
}
