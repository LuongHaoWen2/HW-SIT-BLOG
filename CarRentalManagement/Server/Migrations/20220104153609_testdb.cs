using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class testdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "e7413222-4ebb-439a-98f9-9a3c3fb1e480");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "c7669743-eef1-46d9-a5c7-d7ccba64d816");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ad32d8b-36d1-4efa-a859-c6f059d9c864", "AQAAAAEAACcQAAAAEC6edI7sK4in+nl0Ciumimjt9k/43XsdjdayGh5vVco0UY70Rmnv+6zCryPxvmQUHQ==", "73a3cd4f-df36-4d7a-9fe6-3cbc39245390" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 102, DateTimeKind.Local).AddTicks(2383), new DateTime(2022, 1, 4, 23, 36, 9, 102, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 102, DateTimeKind.Local).AddTicks(9286), new DateTime(2022, 1, 4, 23, 36, 9, 102, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(2762), new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(2769), new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(516), new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(524), new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(525), new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(527), new DateTime(2022, 1, 4, 23, 36, 9, 104, DateTimeKind.Local).AddTicks(528) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "0d0b0d19-62fd-4632-93a8-3ecaf4046bed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "402c572c-c226-4329-bc21-0461fd41e8f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00e68928-ea4e-4335-a53e-5e955973869e", "AQAAAAEAACcQAAAAEOLMoQHDSzeMktTYGeMsd/1Fk5Dxv4I6wWHK9qtWOE6mg3GZf+nm72qV5HO72J/k9w==", "2fbb2100-5519-4872-85e9-f4ebf4c67bad" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 379, DateTimeKind.Local).AddTicks(7674), new DateTime(2022, 1, 4, 16, 45, 53, 381, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 381, DateTimeKind.Local).AddTicks(9372), new DateTime(2022, 1, 4, 16, 45, 53, 381, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 387, DateTimeKind.Local).AddTicks(1225), new DateTime(2022, 1, 4, 16, 45, 53, 387, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 387, DateTimeKind.Local).AddTicks(1250), new DateTime(2022, 1, 4, 16, 45, 53, 387, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2199), new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2228), new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2236), new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 1, 4, 16, 45, 53, 386, DateTimeKind.Local).AddTicks(2246) });
        }
    }
}
