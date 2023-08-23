namespace Blog.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
        public Category()
        {
            Articles = new HashSet<Article>();
        }
    }
}
