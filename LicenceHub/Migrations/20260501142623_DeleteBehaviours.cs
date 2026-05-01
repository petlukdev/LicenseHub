using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicenseHub.Migrations
{
    /// <inheritdoc />
    public partial class DeleteBehaviours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Owners_OwnerId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Suppliers_SupplierId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Departments_DepartmentId",
                table: "Owners");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Owners_OwnerId",
                table: "Licenses",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Suppliers_SupplierId",
                table: "Licenses",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Departments_DepartmentId",
                table: "Owners",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Owners_OwnerId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Suppliers_SupplierId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Departments_DepartmentId",
                table: "Owners");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Owners_OwnerId",
                table: "Licenses",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Suppliers_SupplierId",
                table: "Licenses",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Departments_DepartmentId",
                table: "Owners",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
