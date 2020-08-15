using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Software" },
                    { 2, "Automation" },
                    { 3, "HR" },
                    { 4, "Finance" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "deep@kush.com", "Deep", 0, "Kush", "images/pic03.jpg" },
                    { 2, new DateTime(1997, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "deep2@kush2.com", "Deep2", 1, "Kush2", "images/pic04.jpg" },
                    { 3, new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "deep3@kush3.com", "Deep3", 0, "Kush3", "images/pic05.jpg" },
                    { 4, new DateTime(1997, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "deep4@kush4.com", "Deep4", 0, "Kush4", "images/pic06.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
