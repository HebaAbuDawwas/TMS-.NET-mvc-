using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Migrations
{
    public partial class newDatabaseM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeesPerDay = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "tblProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProjects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployeesProjects",
                columns: table => new
                {
                    EmployeeProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployeesProjects", x => x.EmployeeProjectId);
                    table.ForeignKey(
                        name: "FK_tblEmployeesProjects_tblEmployees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "tblEmployees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEmployeesProjects_tblProjects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "tblProjects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "EmployeeId", "FeesPerDay", "Name" },
                values: new object[,]
                {
                    { 1, 15.0, "Employee 1" },
                    { 2, 25.0, "Employee 2" },
                    { 3, 10.0, "Employee 3" }
                });

            migrationBuilder.InsertData(
                table: "tblProjects",
                columns: new[] { "ProjectId", "Name", "Size" },
                values: new object[,]
                {
                    { 1, "Project 1", 0 },
                    { 2, "Project 2", 2 },
                    { 3, "Project 3", 1 }
                });

            migrationBuilder.InsertData(
                table: "tblEmployeesProjects",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "EndDate", "ProjectId", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 20, 12, 15, 43, 745, DateTimeKind.Local).AddTicks(9912), 1, new DateTime(2021, 12, 15, 12, 15, 43, 743, DateTimeKind.Local).AddTicks(3618), 2 },
                    { 4, 2, new DateTime(2021, 12, 20, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(805), 1, new DateTime(2021, 12, 12, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(801), 1 },
                    { 2, 2, new DateTime(2021, 12, 24, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(788), 2, new DateTime(2021, 12, 17, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(772), 1 },
                    { 3, 3, new DateTime(2021, 12, 29, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(797), 3, new DateTime(2021, 12, 24, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(793), 0 },
                    { 5, 1, new DateTime(2021, 12, 23, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(813), 3, new DateTime(2021, 12, 18, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(809), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeesProjects_EmployeeId",
                table: "tblEmployeesProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeesProjects_ProjectId",
                table: "tblEmployeesProjects",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployeesProjects");

            migrationBuilder.DropTable(
                name: "tblEmployees");

            migrationBuilder.DropTable(
                name: "tblProjects");
        }
    }
}
