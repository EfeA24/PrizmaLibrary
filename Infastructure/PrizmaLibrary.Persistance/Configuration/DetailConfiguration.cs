using Bogus;
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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("en");

            Detail detail1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Paragraph(),
                IsDeleted = false,
                CategoryId = 1
            };

            Detail detail2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Paragraph(),
                IsDeleted = false,
                CategoryId = 2
            };

            Detail detail3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Paragraph(),
                IsDeleted = false,
                CategoryId = 3
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}
