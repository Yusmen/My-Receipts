namespace MyReceipts.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyReceipts.Web.ViewModels.Votes;
    using System.Security.Claims;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api/[controller]")]
    public class VotesController : BaseController
    {
        private readonly IVotesService votesService;

        public VotesController(IVotesService votesService)
        {
            this.votesService = votesService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<PostResponseViewModel>> Post(PostVoteResponseModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.votesService.SetVoteAsync(input.RecipeId, userId, input.Value);
            var averageVotes = this.votesService.GetAverageVotes(input.RecipeId);
            return new PostResponseViewModel { AverageVote = averageVotes };
        }
    }
}
