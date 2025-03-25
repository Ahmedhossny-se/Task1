using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountStatus",
                schema: "Task1",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountStatus",
                schema: "Task1",
                table: "Users");
        }
    }
}
