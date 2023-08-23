using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.FileIO;
using System;

namespace Blog.Data.TypeConfiguration
{
    public class ImageTypeConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = Guid.Parse("659E7A9F-96E8-4B89-9A9A-6C27DE62A083"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Image
                {
                    Id = Guid.Parse("9324BE78-0522-499F-97A2-BC8B5AF88ABC"),
                    FileName = "images/vstest",
                    FileType = "png",
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                }
                );
        }
    }
}
