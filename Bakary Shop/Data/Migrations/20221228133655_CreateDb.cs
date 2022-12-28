using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakary_Shop.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "ProductName", "Price" },
                values: new object[] { 1, "Cake Cake", "product-2.jpg", "Cake", 44m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "ProductName", "Price" },
                values: new object[] { 2, "Cookies Cookies", "about-2.jpg", "Bread", 44m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "ProductName", "Price" },
                values: new object[] { 3, "Cookies Cookies", "carousel-1.jpg", "Cookies", 44m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "ProductName", "Price" },
                values: new object[] { 4, "carousel carousel", "carousel-2.jpg", "carousel", 44m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "ProductName", "Price" },
                values: new object[] { 5, "Cookies Cookies", "product-3.jpg", "Cookies", 44m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "ProductName", "Price" },
                values: new object[] { 6, "carousel carousel", "product-4.jpg", "carousel", 44m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
