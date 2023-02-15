using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingTools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TakenById = table.Column<Guid>(type: "TEXT", nullable: true),
                    ToolDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ToolMarking = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tools_Users_TakenById",
                        column: x => x.TakenById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tools_TakenById",
                table: "Tools",
                column: "TakenById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tools");
        }
    }
}
