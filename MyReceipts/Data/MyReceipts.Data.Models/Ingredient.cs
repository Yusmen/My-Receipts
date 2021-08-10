namespace MyReceipts.Data.Models
{
    using System.Collections.Generic;

    using MyReceipts.Data.Common.Models;
    using MyReceipts.Data.Models;

    public class Ingredient : BaseDeletableModel<int>
    {
        public Ingredient()
        {
            this.Recipes = new HashSet<RecipeIngredient>();
        }

        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> Recipes { get; set; }
    }
}
