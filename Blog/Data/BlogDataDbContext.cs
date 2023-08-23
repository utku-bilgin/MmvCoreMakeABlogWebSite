using Blog.Data.TypeConfiguration;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }


        public BlogDataDbContext(DbContextOptions<BlogDataDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleTypeConfiguration())
                        .ApplyConfiguration(new CategoryTypeConfiguration())
                        .ApplyConfiguration(new ImageTypeConfiguration());
        }
    }
}
