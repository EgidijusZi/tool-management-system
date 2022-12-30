using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(6)",
                table: "Aircrafts",
                newName: "AircraftRegistration");

            migrationBuilder.RenameColumn(
                name: "nvarchar(5)",
                table: "Aircrafts",
                newName: "ManufacturerSerialNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManufacturerSerialNumber",
                table: "Aircrafts",
                newName: "nvarchar(5)");

            migrationBuilder.RenameColumn(
                name: "AircraftRegistration",
                table: "Aircrafts",
                newName: "nvarchar(6)");
        }
    }
}
