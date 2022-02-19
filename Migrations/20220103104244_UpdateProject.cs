using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class UpdateProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Icon",
                table: "tblProjects",
                type: "varbinary(max)",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "tblProjects");

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
    }
}
