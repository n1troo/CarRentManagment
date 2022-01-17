using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentManagment.Server.Migrations
{
    public partial class ABCSDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb32f9fe-8b49-436c-8070-f286fb5b8a95",
                column: "ConcurrencyStamp",
                value: "6a221a90-1987-4951-af09-d97b0edb9acc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db35fdb4-b9b1-448f-ab90-c2e423a8731d",
                column: "ConcurrencyStamp",
                value: "eb5f4db9-f298-4631-b319-60f51c21e36b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e350415-83bb-4464-9a02-2363e6d4aabb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3dc05ee-3bcb-4d14-a22c-bdd92fd5cb0f", "AQAAAAEAACcQAAAAEMFOYprsX6CePwJE9hzFy25pQLbqPEzsjWc2vZ3wAKvnjOPMqx1ku3ehYYzpqkeobA==", "177a0822-5741-41ab-9dd8-2edcc9b0fa83" });

            migrationBuilder.UpdateData(
                table: "Kolors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(3523), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Kolors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(3597), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4029), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4119), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4127), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4269), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4276), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4282), new DateTime(2022, 1, 10, 11, 4, 54, 794, DateTimeKind.Local).AddTicks(4285) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb32f9fe-8b49-436c-8070-f286fb5b8a95",
                column: "ConcurrencyStamp",
                value: "a700eb4e-57fa-4eeb-a68e-59553a5a5951");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db35fdb4-b9b1-448f-ab90-c2e423a8731d",
                column: "ConcurrencyStamp",
                value: "8c84b9d8-1037-44e3-a08d-7c970be7a96c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e350415-83bb-4464-9a02-2363e6d4aabb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2a39a4c-3600-4116-b70e-d7a5af7d4d11", "AQAAAAEAACcQAAAAEB5jQHRf7SL6TsVl4iuBLhYBZIGj7054ALZMwJeGq2BcbxcSe+7+iYdOfqIfB5hn5Q==", "9973f8ad-9e5b-43ec-b812-68d43b578eed" });

            migrationBuilder.UpdateData(
                table: "Kolors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9755), new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Kolors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9816), new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9977), new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9980), new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9983), new DateTime(2021, 12, 8, 11, 39, 52, 244, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(37), new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(40), new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(43), new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(46), new DateTime(2021, 12, 8, 11, 39, 52, 245, DateTimeKind.Local).AddTicks(47) });
        }
    }
}
