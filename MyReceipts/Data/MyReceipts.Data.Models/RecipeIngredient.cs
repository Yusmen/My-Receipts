namespace MyReceipts.Data.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public int IngeredientId { get; set; }

        public string Quantity { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
