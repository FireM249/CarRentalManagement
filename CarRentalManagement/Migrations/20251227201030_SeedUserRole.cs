using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6a42dfa4-be3e-4243-8870-6fa9ea4a127d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEN5pM+JS/bBjYauIKQPt+yVIuFg/VRaTiqHJtwZ2wLprKt3DhhUXWrp10vvynn4S5A==", null, false, "27edb502-1016-474e-94b4-1481e40a01bd", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6647), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6661), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6791), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6793), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6876), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6879), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6881), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6882), new DateTime(2025, 12, 28, 4, 10, 29, 928, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4571), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4583), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4707), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4710), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4789), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4790), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4793), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4794), new DateTime(2025, 12, 28, 2, 19, 19, 862, DateTimeKind.Local).AddTicks(4795) });
        }
    }
}
