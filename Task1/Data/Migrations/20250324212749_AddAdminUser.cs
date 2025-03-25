using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Task1].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FisrtName], [LastName]) VALUES (N'010a0998-be67-485a-a90a-2d902b6b5673', N'Test', N'TEST', N'Test@swe.com', N'TEST@SWE.COM', 0, N'AQAAAAIAAYagAAAAEGXT9SbFLfc9y56honAPcnuQFusq1or92Lw5iCVgb2QQ9zSQVBmc1OVrZQYFLaSjqA==', N'4KHJXGB2VRHZKXVFZEOWQVE43UQ3O726', N'1f07aa39-c426-444e-b1c3-957248bd4b86', NULL, 0, 0, NULL, 1, 0, N'Ahmed', N'Hossny')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Task1].[Users] WHERE Id = '010a0998-be67-485a-a90a-2d902b6b5673'");  
        }
    }
}
