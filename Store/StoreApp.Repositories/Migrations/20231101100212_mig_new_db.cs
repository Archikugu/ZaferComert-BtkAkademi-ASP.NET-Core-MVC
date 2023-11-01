using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Repositories.Migrations
{
    public partial class mig_new_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Line1 = table.Column<string>(type: "TEXT", nullable: false),
                    Line2 = table.Column<string>(type: "TEXT", nullable: true),
                    Line3 = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    GiftWrap = table.Column<bool>(type: "INTEGER", nullable: false),
                    Shipped = table.Column<bool>(type: "INTEGER", nullable: false),
                    OrderedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "CartLine",
                columns: table => new
                {
                    CartLineID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLine", x => x.CartLineID);
                    table.ForeignKey(
                        name: "FK_CartLine_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_CartLine_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Book" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Electronic" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[] { 1, 2, "/images/1.jpg", 17000m, "Computer", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[] { 2, 2, "/images/2.jpg", 1000m, "Keyboard", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[] { 3, 2, "/images/3.jpg", 500m, "Mouse", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[] { 4, 2, "/images/4.jpg", 7000m, "Monitor", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[] { 5, 2, "/images/5.jpg", 1500m, "Deck", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[] { 6, 1, "/images/6.jpg", 1500m, "Hamlet", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ImageUrl", "Price", "ProductName", "Summary" },
                values: new object[] { 7, 1, "/images/7.jpg", 1500m, "History", "" });

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_OrderID",
                table: "CartLine",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_ProductID",
                table: "CartLine",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLine");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
