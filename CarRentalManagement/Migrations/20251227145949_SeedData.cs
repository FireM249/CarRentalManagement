using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2773), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2786), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2788), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2788), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2928), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2930), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2931), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(2932), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3085), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3086), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3088), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3088), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3089), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3090), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3091), new DateTime(2025, 12, 27, 22, 59, 49, 434, DateTimeKind.Local).AddTicks(3091), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
