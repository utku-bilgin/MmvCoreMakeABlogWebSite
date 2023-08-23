namespace Blog.Models
{
    public class Image : BaseEntity
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article> Articles { get; set; }
        public Image()
        {
            Articles = new HashSet<Article>();
        }
    }
}
