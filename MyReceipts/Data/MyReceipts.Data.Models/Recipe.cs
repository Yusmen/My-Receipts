﻿namespace MyReceipts.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MyReceipts.Data.Common.Models;

    public class Recipe : BaseDeletableModel<int>
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<RecipeIngredient>();
            this.Images = new HashSet<Image>();
        }

        public string Name { get; set; }

        public string Instructions { get; set; }

        public TimeSpan PeparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionCount { get; set; }

        public string OriginalUrl { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int CetegoryId { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
