using Microsoft.EntityFrameworkCore;
using PrizmaLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Persistance.Context
{
    public class AddDbContext : DbContext
    {
        public AddDbContext() { }

        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AddDbContext).Assembly);
        }
    }
}
