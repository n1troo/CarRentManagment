using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentManagment.Server.Data.Migrations
{
    public partial class UserAndUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb32f9fe-8b49-436c-8070-f286fb5b8a95",
                column: "ConcurrencyStamp",
                value: "8b2a2e6e-c6cb-4694-9739-eb565b04a132");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db35fdb4-b9b1-448f-ab90-c2e423a8731d",
                column: "ConcurrencyStamp",
                value: "ae3c86aa-6554-48df-a296-926fcc8b05da");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e350415-83bb-4464-9a02-2363e6d4aabb", 0, "54e3e430-7798-4816-b7ef-35a2fdd4b50b", "admin@o2.pl", false, "Admin", "User", false, null, "ADMIN@O2.PL", "ADMIN", "AQAAAAEAACcQAAAAEEDsyr5wjYYaxF8ypjZ24QH2l0uHYy/eg9enstn+vweAVinTsK/ienG9gUcYOzS6NQ==", null, false, "ab6dda2a-771b-40a0-ac71-b45147779986", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6703), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6755), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6890), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6894), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6897), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6959), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6962), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6965), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6967), new DateTime(2021, 11, 23, 13, 5, 54, 805, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "db35fdb4-b9b1-448f-ab90-c2e423a8731d", "0e350415-83bb-4464-9a02-2363e6d4aabb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db35fdb4-b9b1-448f-ab90-c2e423a8731d", "0e350415-83bb-4464-9a02-2363e6d4aabb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e350415-83bb-4464-9a02-2363e6d4aabb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb32f9fe-8b49-436c-8070-f286fb5b8a95",
                column: "ConcurrencyStamp",
                value: "a21ae19a-d381-40fe-97f3-9eea9e7b4f1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db35fdb4-b9b1-448f-ab90-c2e423a8731d",
                column: "ConcurrencyStamp",
                value: "de59585f-6900-42d6-8b97-30b706d02a0e");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8111), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8148), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8286), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8290), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8292), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8338), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8340), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8343), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8345), new DateTime(2021, 11, 23, 13, 4, 3, 731, DateTimeKind.Local).AddTicks(8346) });
        }
    }
}
