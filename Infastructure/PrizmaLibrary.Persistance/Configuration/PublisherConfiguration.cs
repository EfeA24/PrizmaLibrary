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
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            Faker faker = new("en");

            Publisher publisher1 = new()
            {
                Id = 1,
                Name = faker.Company.CompanyName(),
                Description = faker.Lorem.Paragraph(),
                Address = faker.Address.StreetAddress(),
                City = faker.Address.City(),
                Phone = faker.Phone.PhoneNumber(),
                Email = faker.Internet.Email(),
                Website = faker.Internet.Url()
            };

            Publisher publisher2 = new()
            {
                Id = 2,
                Name = faker.Company.CompanyName(),
                Description = faker.Lorem.Paragraph(),
                Address = faker.Address.StreetAddress(),
                City = faker.Address.City(),
                Phone = faker.Phone.PhoneNumber(),
                Email = faker.Internet.Email(),
                Website = faker.Internet.Url()
            };

            Publisher publisher3 = new()
            {
                Id = 3,
                Name = faker.Company.CompanyName(),
                Description = faker.Lorem.Paragraph(),
                Address = faker.Address.StreetAddress(),
                City = faker.Address.City(),
                Phone = faker.Phone.PhoneNumber(),
                Email = faker.Internet.Email(),
                Website = faker.Internet.Url()
            };

            builder.HasData(publisher1, publisher2, publisher3);
        }
    }
}
