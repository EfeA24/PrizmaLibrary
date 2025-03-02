﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrizmaLibrary.Persistance.Context;

#nullable disable

namespace PrizmaLibrary.Persistance.Migrations
{
    [DbContext(typeof(AddDbContext))]
    partial class AddDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "CategoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("PrizmaLibrary.Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Kenya Farrell",
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(34),
                            Description = "Autem tempora est iusto illum. Adipisci cupiditate ut. Vitae aut voluptate optio et dolor et quas. Et optio debitis quis qui ut placeat deleniti et. At nihil ullam quasi minima accusantium numquam ut.",
                            IsDeleted = false,
                            Price = 26.339417314366690m,
                            PublisherId = 1,
                            Title = "Beatae ullam illo aut iure suscipit."
                        },
                        new
                        {
                            Id = 2,
                            Author = "Junius Marquardt",
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(300),
                            Description = "Eveniet suscipit dolores nisi. Et occaecati magnam eos explicabo dolor perferendis impedit ex magnam. Modi et amet ab et quasi mollitia.",
                            IsDeleted = false,
                            Price = 38.049210487086940m,
                            PublisherId = 2,
                            Title = "Culpa at id ipsa sit corrupti voluptatum tenetur."
                        },
                        new
                        {
                            Id = 3,
                            Author = "Lennie Balistreri",
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(378),
                            Description = "Quia quae fugit. Doloribus facilis eos maiores neque omnis qui et distinctio natus. Sit laborum eos odio et. İllo quibusdam ad nihil nostrum explicabo rerum ut pariatur illo.",
                            IsDeleted = false,
                            Price = 37.088961156663580m,
                            PublisherId = 3,
                            Title = "Cupiditate soluta qui quae ullam sed sunt ut dignissimos deleniti."
                        });
                });

            modelBuilder.Entity("PrizmaLibrary.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1471),
                            IsDeleted = false,
                            Name = "History",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1473),
                            IsDeleted = false,
                            Name = "Science",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1474),
                            IsDeleted = false,
                            Name = "Literature",
                            ParentId = 0,
                            Priorty = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1475),
                            IsDeleted = false,
                            Name = "World War History",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1476),
                            IsDeleted = false,
                            Name = "Programming",
                            ParentId = 2,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1476),
                            IsDeleted = false,
                            Name = "Novel",
                            ParentId = 3,
                            Priorty = 3
                        });
                });

            modelBuilder.Entity("PrizmaLibrary.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 746, DateTimeKind.Local).AddTicks(1458),
                            Description = "Labore accusamus facilis et quia. Modi accusamus voluptas est non quisquam dolorem. Molestiae quia dolores repellat omnis deserunt atque et similique expedita. Non aut rem animi.",
                            IsDeleted = false,
                            Title = "Dignissimos animi ab qui et quisquam et."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 746, DateTimeKind.Local).AddTicks(1610),
                            Description = "Quibusdam non fugiat perferendis recusandae modi quia quo. Eum aliquid enim minus mollitia reprehenderit aut. Commodi harum facere. Et saepe optio. Consequatur dolorem fugiat et minima pariatur dolorum. Molestiae officia quae dolorem at ut enim facere.",
                            IsDeleted = false,
                            Title = "Facere rerum nihil ipsum voluptas cupiditate magni."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 3, 2, 17, 37, 49, 746, DateTimeKind.Local).AddTicks(1747),
                            Description = "Perspiciatis est ex quia sed rerum illum architecto dolorem architecto. Fuga voluptatem quisquam. Consequuntur aut consequatur.",
                            IsDeleted = false,
                            Title = "Perspiciatis necessitatibus magni."
                        });
                });

            modelBuilder.Entity("PrizmaLibrary.Domain.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "0860 Ernestine Locks",
                            City = "East Jennings",
                            Description = "Eos sed molestiae sunt omnis sit. Est omnis eum placeat vitae quisquam et ipsum occaecati. Eum qui rerum quos ad quidem iste deleniti. Sunt ea laborum explicabo enim praesentium non. Eos qui aut cumque assumenda harum iste. Sit omnis qui doloremque cumque sed hic laudantium.",
                            Email = "Eliezer_Harber19@hotmail.com",
                            Name = "Jaskolski, Armstrong and Windler",
                            Phone = "1-917-826-8263 x07780",
                            Website = "http://holly.org"
                        },
                        new
                        {
                            Id = 2,
                            Address = "29806 Ruecker Tunnel",
                            City = "Liamshire",
                            Description = "Eum est suscipit. Quia ut iste. Tempora id nihil non enim consequuntur autem voluptatum dignissimos. Velit assumenda veritatis.",
                            Email = "Briana47@yahoo.com",
                            Name = "Wiza - Gibson",
                            Phone = "667.838.9163 x109",
                            Website = "http://sandy.name"
                        },
                        new
                        {
                            Id = 3,
                            Address = "98188 Anderson Flat",
                            City = "West Lukas",
                            Description = "Omnis ipsa illum voluptatem nisi quo hic qui. Ab voluptatibus molestias. İllum adipisci et quas repellendus enim architecto aut vitae. Expedita consectetur dignissimos voluptas laudantium accusantium repudiandae eum assumenda et.",
                            Email = "Kiel0@gmail.com",
                            Name = "Bernhard, Farrell and Sporer",
                            Phone = "451-605-4557 x9646",
                            Website = "https://mitchel.org"
                        });
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("PrizmaLibrary.Domain.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrizmaLibrary.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrizmaLibrary.Domain.Entities.Book", b =>
                {
                    b.HasOne("PrizmaLibrary.Domain.Entities.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("PrizmaLibrary.Domain.Entities.Detail", b =>
                {
                    b.HasOne("PrizmaLibrary.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PrizmaLibrary.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
