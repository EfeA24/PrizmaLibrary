using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrizmaLibrary.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => new { x.BooksId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_BookCategory_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1471), false, "History", 0, 1 },
                    { 2, new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1473), false, "Science", 0, 2 },
                    { 3, new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1474), false, "Literature", 0, 3 },
                    { 4, new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1475), false, "World War History", 1, 1 },
                    { 5, new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1476), false, "Programming", 2, 2 },
                    { 6, new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(1476), false, "Novel", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Address", "City", "Description", "Email", "Name", "Phone", "Website" },
                values: new object[,]
                {
                    { 1, "0860 Ernestine Locks", "East Jennings", "Eos sed molestiae sunt omnis sit. Est omnis eum placeat vitae quisquam et ipsum occaecati. Eum qui rerum quos ad quidem iste deleniti. Sunt ea laborum explicabo enim praesentium non. Eos qui aut cumque assumenda harum iste. Sit omnis qui doloremque cumque sed hic laudantium.", "Eliezer_Harber19@hotmail.com", "Jaskolski, Armstrong and Windler", "1-917-826-8263 x07780", "http://holly.org" },
                    { 2, "29806 Ruecker Tunnel", "Liamshire", "Eum est suscipit. Quia ut iste. Tempora id nihil non enim consequuntur autem voluptatum dignissimos. Velit assumenda veritatis.", "Briana47@yahoo.com", "Wiza - Gibson", "667.838.9163 x109", "http://sandy.name" },
                    { 3, "98188 Anderson Flat", "West Lukas", "Omnis ipsa illum voluptatem nisi quo hic qui. Ab voluptatibus molestias. İllum adipisci et quas repellendus enim architecto aut vitae. Expedita consectetur dignissimos voluptas laudantium accusantium repudiandae eum assumenda et.", "Kiel0@gmail.com", "Bernhard, Farrell and Sporer", "451-605-4557 x9646", "https://mitchel.org" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedDate", "Description", "IsDeleted", "Price", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, "Kenya Farrell", new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(34), "Autem tempora est iusto illum. Adipisci cupiditate ut. Vitae aut voluptate optio et dolor et quas. Et optio debitis quis qui ut placeat deleniti et. At nihil ullam quasi minima accusantium numquam ut.", false, 26.339417314366690m, 1, "Beatae ullam illo aut iure suscipit." },
                    { 2, "Junius Marquardt", new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(300), "Eveniet suscipit dolores nisi. Et occaecati magnam eos explicabo dolor perferendis impedit ex magnam. Modi et amet ab et quasi mollitia.", false, 38.049210487086940m, 2, "Culpa at id ipsa sit corrupti voluptatum tenetur." },
                    { 3, "Lennie Balistreri", new DateTime(2025, 3, 2, 17, 37, 49, 745, DateTimeKind.Local).AddTicks(378), "Quia quae fugit. Doloribus facilis eos maiores neque omnis qui et distinctio natus. Sit laborum eos odio et. İllo quibusdam ad nihil nostrum explicabo rerum ut pariatur illo.", false, 37.088961156663580m, 3, "Cupiditate soluta qui quae ullam sed sunt ut dignissimos deleniti." }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 2, 17, 37, 49, 746, DateTimeKind.Local).AddTicks(1458), "Labore accusamus facilis et quia. Modi accusamus voluptas est non quisquam dolorem. Molestiae quia dolores repellat omnis deserunt atque et similique expedita. Non aut rem animi.", false, "Dignissimos animi ab qui et quisquam et." },
                    { 2, 2, new DateTime(2025, 3, 2, 17, 37, 49, 746, DateTimeKind.Local).AddTicks(1610), "Quibusdam non fugiat perferendis recusandae modi quia quo. Eum aliquid enim minus mollitia reprehenderit aut. Commodi harum facere. Et saepe optio. Consequatur dolorem fugiat et minima pariatur dolorum. Molestiae officia quae dolorem at ut enim facere.", false, "Facere rerum nihil ipsum voluptas cupiditate magni." },
                    { 3, 3, new DateTime(2025, 3, 2, 17, 37, 49, 746, DateTimeKind.Local).AddTicks(1747), "Perspiciatis est ex quia sed rerum illum architecto dolorem architecto. Fuga voluptatem quisquam. Consequuntur aut consequatur.", false, "Perspiciatis necessitatibus magni." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_CategoriesId",
                table: "BookCategory",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
