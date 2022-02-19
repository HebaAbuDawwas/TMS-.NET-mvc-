using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Photo",
                value: "/Images/userprofile.png");

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Photo",
                value: "/Images/employee2.jpg");

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Photo",
                value: "/Images/userprofile.png");

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 1, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(4661), new DateTime(2021, 12, 27, 12, 33, 45, 68, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 5, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5247), new DateTime(2021, 12, 29, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 10, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 1, 5, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 1, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5257), new DateTime(2021, 12, 24, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5261), new DateTime(2021, 12, 30, 12, 33, 45, 70, DateTimeKind.Local).AddTicks(5259) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
