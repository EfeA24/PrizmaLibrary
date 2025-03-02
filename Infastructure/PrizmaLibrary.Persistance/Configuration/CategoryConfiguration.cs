using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrizmaLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Persistance.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                ParentId = 0,
                Name = "History",
                Priorty = 1,
                IsDeleted = false
            };

            Category category2 = new()
            {
                Id = 2,
                ParentId = 0,
                Name = "Science",
                Priorty = 2,
                IsDeleted = false
            };

            Category category3 = new()
            {
                Id = 3,
                ParentId = 0,
                Name = "Literature",
                Priorty = 3,
                IsDeleted = false
            };

            Category parent1 = new()
            {
                Id = 4,
                ParentId = 1,
                Name = "World War History",
                Priorty = 1,
                IsDeleted = false
            };

            Category parent2 = new()
            {
                Id = 5,
                ParentId = 2,
                Name = "Programming",
                Priorty = 2,
                IsDeleted = false
            };

            Category parent3 = new()
            {
                Id = 6,
                ParentId = 3,
                Name = "Novel",
                Priorty = 3,
                IsDeleted = false
            };

            builder.HasData(category1, category2, category3, parent1, parent2, parent3);
        }
    }
}
