using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class Add_data_M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
