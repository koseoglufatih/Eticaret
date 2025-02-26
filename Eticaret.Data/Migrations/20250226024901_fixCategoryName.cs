using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixCategoryName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripton",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Descripton",
                table: "Brands",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 2, 26, 5, 49, 0, 158, DateTimeKind.Local).AddTicks(3576), new Guid("3c95bd44-0bdb-4d31-960a-218e556c13c6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 26, 5, 49, 0, 158, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 26, 5, 49, 0, 158, DateTimeKind.Local).AddTicks(6498));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Descripton");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Brands",
                newName: "Descripton");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2024, 12, 6, 8, 15, 34, 840, DateTimeKind.Local).AddTicks(7681), new Guid("77f51578-dd97-4629-8263-d4a5d7d6ebd3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 6, 8, 15, 34, 842, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 6, 8, 15, 34, 842, DateTimeKind.Local).AddTicks(9947));
        }
    }
}
