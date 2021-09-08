namespace MyReceipts.Web.ViewModels.Recipes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseRecipeInputModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(100)]
        public string Instructions { get; set; }

        [Range(0, 24 * 60)]
        [Display(Name = "Preparation time (in minutes).")]
        public int PeparationTime { get; set; }

        [Range(0, 24 * 60)]
        [Display(Name = "Cooking time (in minutes).")]
        public int CookingTime { get; set; }

        [Range(1, 100)]
        public int PortionCount { get; set; }

        public int CetegoryId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
