using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Repositories.Migrations
{
    public partial class mig_add_identityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09bfb182-5f6a-49cf-b8d8-3c92fb889603", "a234f35e-fed0-4ed9-b4d0-14e0bfd52762", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d19c0b94-38b1-4062-96da-4aed45bfb85b", "aef73321-86c0-4349-a857-6b9969fc9bce", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d473b2de-2b6c-47cb-bad3-aa3b0ab9fbe1", "2dd3e42c-2935-4780-8eac-17b5bb0503e1", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09bfb182-5f6a-49cf-b8d8-3c92fb889603");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d19c0b94-38b1-4062-96da-4aed45bfb85b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d473b2de-2b6c-47cb-bad3-aa3b0ab9fbe1");
        }
    }
}
