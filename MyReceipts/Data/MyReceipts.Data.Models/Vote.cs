namespace MyReceipts.Data.Models
{
    using MyReceipts.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public virtual Recipe Recipe { get; set; }

        public int RecipeId { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public byte Value { get; set; }
    }
}
