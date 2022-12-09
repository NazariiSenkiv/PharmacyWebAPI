using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Brand", "Category", "Name", "Price", "ProductionYear" },
                values: new object[] { 99, "SBranD", "Universal", "SeededMed1", 1000f, 2021 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Brand", "Category", "Name", "Price", "ProductionYear" },
                values: new object[] { 100, "THm", "Throat", "ThroatMed", 30f, 2022 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Brand", "Category", "Name", "Price", "ProductionYear" },
                values: new object[] { 101, "P", "P", "Paracetamol", 100f, 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
