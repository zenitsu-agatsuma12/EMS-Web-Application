using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS_Web_Application.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(type: "ntext", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Department" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "CSR" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DOB", "Department", "DepartmentId", "Email", "Full_Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 20, 21, 33, 17, 516, DateTimeKind.Local).AddTicks(7556), "IT", 1, "alvin@gmail.com", "Alvin Root", "099232312" },
                    { 2, new DateTime(2023, 3, 21, 21, 33, 17, 516, DateTimeKind.Local).AddTicks(7575), "HR", 2, "trish@gmail.com", "Tricia Tagle", "099232322312" },
                    { 3, new DateTime(2023, 3, 22, 21, 33, 17, 516, DateTimeKind.Local).AddTicks(7577), "CSR", 3, "Joan@gmail.com", "Joan DC", "09319232312" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
