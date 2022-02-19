using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class AddIconMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9020), new DateTime(2021, 12, 28, 16, 10, 30, 257, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9618), new DateTime(2021, 12, 30, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9623), new DateTime(2022, 1, 6, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9628), new DateTime(2021, 12, 25, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9632), new DateTime(2021, 12, 31, 16, 10, 30, 258, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "tblProjects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "Icon",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "tblProjects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "Icon",
                value: new byte[0]);

            migrationBuilder.UpdateData(
                table: "tblProjects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "Icon",
                value: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 1, 12, 42, 44, 430, DateTimeKind.Local).AddTicks(9545), new DateTime(2021, 12, 27, 12, 42, 44, 429, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 5, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(179), new DateTime(2021, 12, 29, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 10, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(185), new DateTime(2022, 1, 5, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 1, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(189), new DateTime(2021, 12, 24, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(193), new DateTime(2021, 12, 30, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "tblProjects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                table: "tblProjects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                table: "tblProjects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "Icon",
                value: null);
        }
    }
}
