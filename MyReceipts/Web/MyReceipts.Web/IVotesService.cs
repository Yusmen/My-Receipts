namespace MyReceipts.Web
{
    using System.Threading.Tasks;

    public interface IVotesService
    {
        Task SetVoteAsync(int recipe, string userId, byte value);

        double GetAverageVotes(int recipeId);
    }
}
