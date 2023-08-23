namespace Blog.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }

        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        public Image Image { get; set; }
        public Guid ImageId { get; set; }


    }
}
