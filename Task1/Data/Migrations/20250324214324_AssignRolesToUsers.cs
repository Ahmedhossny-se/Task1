using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssignRolesToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Task1].[UserRoles] (UserId,RoleId) SELECT '010a0998-be67-485a-a90a-2d902b6b5673','69900074-3895-4e06-a1a2-7c96c2acf9ae'");
            migrationBuilder.Sql("INSERT INTO [Task1].[UserRoles] (UserId,RoleId) SELECT '1e0d539f-379e-41c0-840e-66476558aff5','61a013c2-2ba4-4566-934a-96d7bf02a3fe'");
            migrationBuilder.Sql("INSERT INTO [Task1].[UserRoles] (UserId,RoleId) SELECT '4430b66c-6cea-4818-86e2-bdd83d00a4be','60dfbd64-00ca-4153-b3e7-6a50e5ca5b1c'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Task1].[UserRoles] WHERE UserId = '010a0998-be67-485a-a90a-2d902b6b5673'");
            migrationBuilder.Sql("DELETE FROM [Task1].[UserRoles] WHERE UserId = '1e0d539f-379e-41c0-840e-66476558aff5'");
            migrationBuilder.Sql("DELETE FROM [Task1].[UserRoles] WHERE UserId = '4430b66c-6cea-4818-86e2-bdd83d00a4be'");
        }
    }
}
