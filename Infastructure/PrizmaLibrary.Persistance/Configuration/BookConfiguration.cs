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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            Faker faker = new("en");

            Book book1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Paragraph(),
                Author = faker.Name.FullName(),
                Price = faker.Random.Decimal(10, 100),
                PublisherId = 1
            };

            Book book2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Paragraph(),
                Author = faker.Name.FullName(),
                Price = faker.Random.Decimal(10, 100),
                PublisherId = 2
            };

            Book book3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Paragraph(),
                Author = faker.Name.FullName(),
                Price = faker.Random.Decimal(10, 100),
                PublisherId = 3
            };

            builder.HasData(book1, book2, book3);
        }
    }
}
