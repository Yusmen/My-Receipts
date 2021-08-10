namespace MyReceipts.Data.Models
{
    using System;

    using MyReceipts.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public Recipe Recipe { get; set; }

        public int RecipeId { get; set; }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        public string AddedbyUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        // The content of image is in the file system   
    }
}
