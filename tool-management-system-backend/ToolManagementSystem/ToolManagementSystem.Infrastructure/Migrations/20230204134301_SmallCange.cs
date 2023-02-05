using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SmallCange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Toolboxes",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Toolboxes",
                newName: "id");
        }
    }
}
