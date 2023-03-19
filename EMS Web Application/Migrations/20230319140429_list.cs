using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS_Web_Application.Migrations
{
    public partial class list : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 20, 22, 4, 28, 937, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2023, 3, 21, 22, 4, 28, 937, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2023, 3, 22, 22, 4, 28, 937, DateTimeKind.Local).AddTicks(2395));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 20, 22, 1, 38, 63, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2023, 3, 21, 22, 1, 38, 63, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2023, 3, 22, 22, 1, 38, 63, DateTimeKind.Local).AddTicks(3877));
        }
    }
}
