using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    nvarchar6 = table.Column<string>(name: "nvarchar(6)", type: "TEXT", nullable: false),
                    EngineType = table.Column<string>(type: "TEXT", nullable: false),
                    nvarchar5 = table.Column<int>(name: "nvarchar(5)", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircrafts");
        }
    }
}
