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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "IT" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "HR" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "CSR" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DOB", "DepartmentId", "Email", "Full_Name", "Phone" },
                values: new object[] { 1, new DateTime(2023, 3, 20, 22, 1, 38, 63, DateTimeKind.Local).AddTicks(3857), 1, "alvin@gmail.com", "Alvin Root", "099232312" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DOB", "DepartmentId", "Email", "Full_Name", "Phone" },
                values: new object[] { 2, new DateTime(2023, 3, 21, 22, 1, 38, 63, DateTimeKind.Local).AddTicks(3876), 2, "trish@gmail.com", "Tricia Tagle", "099232322312" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DOB", "DepartmentId", "Email", "Full_Name", "Phone" },
                values: new object[] { 3, new DateTime(2023, 3, 22, 22, 1, 38, 63, DateTimeKind.Local).AddTicks(3877), 3, "Joan@gmail.com", "Joan DC", "09319232312" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
