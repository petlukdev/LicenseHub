using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHub.Migrations
{
    /// <inheritdoc />
    public partial class NewUniqueIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Licenses_Key_SupplierId",
                table: "Licenses",
                columns: new[] { "Key", "SupplierId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                table: "Departments",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Licenses_Key_SupplierId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Name",
                table: "Departments");
        }
    }
}
