﻿using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.TypeConfiguration
{
    public class ArticleTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Asp.Net Core Deneme Makalesi 1",
                    Content = "Asp.Net Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("AEB70F85-9272-4C29-B71E-7DD2A4FDF3F9"),
                    ImageId = Guid.Parse("659E7A9F-96E8-4B89-9A9A-6C27DE62A083"),
                    CreatedBy = "AdminTest",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Visual Studio Deneme Makalesi 1",
                    Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("9BD797A0-812D-4EAD-B3A4-E549336F6E6F"),
                    ImageId = Guid.Parse("9324BE78-0522-499F-97A2-BC8B5AF88ABC"),
                    CreatedBy = "AdminTest",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
                );
        }
    }
}
