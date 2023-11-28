using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "36d86725-11b4-4d55-99f6-5721c4425f4e", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJpG186zwcfhrJ9oSwVEmX3mC+x3RC5VibSKQtM4oy3LORfKOT+LakO89dxStZFvHA==", null, false, "e0f91888-b3ff-495c-9030-b871880a1159", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4242), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4246), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4546), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4547), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4548), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4549), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4724), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4726), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4727), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4728), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4729), new DateTime(2023, 11, 28, 11, 16, 19, 18, DateTimeKind.Local).AddTicks(4729), "RAV4", "System" }
                });

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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
