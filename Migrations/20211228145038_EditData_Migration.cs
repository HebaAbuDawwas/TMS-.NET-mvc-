using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class EditData_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 26, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(1972), new DateTime(2021, 12, 21, 16, 50, 38, 303, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 30, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4979), new DateTime(2021, 12, 23, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 4, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4986), new DateTime(2021, 12, 30, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 26, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4992), new DateTime(2021, 12, 18, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 29, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4998), new DateTime(2021, 12, 24, 16, 50, 38, 308, DateTimeKind.Local).AddTicks(4995) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 25, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(5574), new DateTime(2021, 12, 20, 12, 3, 53, 21, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 29, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6136), new DateTime(2021, 12, 22, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 3, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6141), new DateTime(2021, 12, 29, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 25, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6146), new DateTime(2021, 12, 17, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6150), new DateTime(2021, 12, 23, 12, 3, 53, 23, DateTimeKind.Local).AddTicks(6148) });
        }
    }
}
