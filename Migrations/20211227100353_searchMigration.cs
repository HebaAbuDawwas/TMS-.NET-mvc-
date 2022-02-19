using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class searchMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 20, 12, 15, 43, 745, DateTimeKind.Local).AddTicks(9912), new DateTime(2021, 12, 15, 12, 15, 43, 743, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 24, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(788), new DateTime(2021, 12, 17, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 29, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(797), new DateTime(2021, 12, 24, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 20, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(805), new DateTime(2021, 12, 12, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "tblEmployeesProjects",
                keyColumn: "EmployeeProjectId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 23, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(813), new DateTime(2021, 12, 18, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(809) });
        }
    }
}
