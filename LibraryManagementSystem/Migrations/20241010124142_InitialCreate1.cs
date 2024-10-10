using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 41, 42, 215, DateTimeKind.Utc).AddTicks(6557), new DateTime(2024, 10, 10, 12, 41, 42, 215, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 41, 42, 215, DateTimeKind.Utc).AddTicks(6569), new DateTime(2024, 10, 10, 12, 41, 42, 215, DateTimeKind.Utc).AddTicks(6569) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 30, 12, 280, DateTimeKind.Utc).AddTicks(7841), new DateTime(2024, 10, 10, 12, 30, 12, 280, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 30, 12, 280, DateTimeKind.Utc).AddTicks(7851), new DateTime(2024, 10, 10, 12, 30, 12, 280, DateTimeKind.Utc).AddTicks(7852) });
        }
    }
}
