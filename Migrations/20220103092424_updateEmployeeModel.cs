using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class updateEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "tblEmployees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Photo",
                value: "userprofile.png");

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Photo",
                value: "employee2.jpg");

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Photo",
                value: "userprofile.png");

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 24, 24, 55, DateTimeKind.Local).AddTicks(9265), new DateTime(2021, 12, 27, 11, 24, 24, 54, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(19), new DateTime(2021, 12, 29, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 10, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(25), new DateTime(2022, 1, 5, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(30), new DateTime(2021, 12, 24, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 4, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(35), new DateTime(2021, 12, 30, 11, 24, 24, 56, DateTimeKind.Local).AddTicks(33) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "tblEmployees");

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 26, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(5670), new DateTime(2021, 12, 21, 16, 52, 56, 205, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 30, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6276), new DateTime(2021, 12, 23, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6282), new DateTime(2021, 12, 30, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 26, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6286), new DateTime(2021, 12, 18, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 29, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6291), new DateTime(2021, 12, 24, 16, 52, 56, 207, DateTimeKind.Local).AddTicks(6289) });
        }
    }
}
