﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] {"Id","Name","NormalizedName","ConcurrencyStamp"},
                values: new object[] {Guid.NewGuid().ToString(),"Employee", "Employee".ToUpper(),Guid.NewGuid().ToString()},
                schema: "Task1"
                );
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "Manager", "Manager".ToUpper(), Guid.NewGuid().ToString() },
                schema: "Task1"
                );
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "SystemAdministrator", "SystemAdministrator".ToUpper(), Guid.NewGuid().ToString() },
                schema: "Task1"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Task1].[Roles]");
        }
    }
}
