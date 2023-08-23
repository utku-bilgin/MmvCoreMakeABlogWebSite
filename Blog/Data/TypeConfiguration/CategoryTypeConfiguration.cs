using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.TypeConfiguration
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("AEB70F85-9272-4C29-B71E-7DD2A4FDF3F9"),
                    Name = "ASP.Net Core",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }, new Category
                {
                    Id = Guid.Parse("9BD797A0-812D-4EAD-B3A4-E549336F6E6F"),
                    Name = "Visual Studio 2022",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
                );
        }
    }
}
