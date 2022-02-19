﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMS.Data;

namespace TMS.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211222101544_newDatabaseM")]
    partial class newDatabaseM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TMS.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("FeesPerDay")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("tblEmployees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            FeesPerDay = 15.0,
                            Name = "Employee 1"
                        },
                        new
                        {
                            EmployeeId = 2,
                            FeesPerDay = 25.0,
                            Name = "Employee 2"
                        },
                        new
                        {
                            EmployeeId = 3,
                            FeesPerDay = 10.0,
                            Name = "Employee 3"
                        });
                });

            modelBuilder.Entity("TMS.Models.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("tblEmployeesProjects");

                    b.HasData(
                        new
                        {
                            EmployeeProjectId = 1,
                            EmployeeId = 1,
                            EndDate = new DateTime(2021, 12, 20, 12, 15, 43, 745, DateTimeKind.Local).AddTicks(9912),
                            ProjectId = 1,
                            StartDate = new DateTime(2021, 12, 15, 12, 15, 43, 743, DateTimeKind.Local).AddTicks(3618),
                            Status = 2
                        },
                        new
                        {
                            EmployeeProjectId = 2,
                            EmployeeId = 2,
                            EndDate = new DateTime(2021, 12, 24, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(788),
                            ProjectId = 2,
                            StartDate = new DateTime(2021, 12, 17, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(772),
                            Status = 1
                        },
                        new
                        {
                            EmployeeProjectId = 3,
                            EmployeeId = 3,
                            EndDate = new DateTime(2021, 12, 29, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(797),
                            ProjectId = 3,
                            StartDate = new DateTime(2021, 12, 24, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(793),
                            Status = 0
                        },
                        new
                        {
                            EmployeeProjectId = 4,
                            EmployeeId = 2,
                            EndDate = new DateTime(2021, 12, 20, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(805),
                            ProjectId = 1,
                            StartDate = new DateTime(2021, 12, 12, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(801),
                            Status = 1
                        },
                        new
                        {
                            EmployeeProjectId = 5,
                            EmployeeId = 1,
                            EndDate = new DateTime(2021, 12, 23, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(813),
                            ProjectId = 3,
                            StartDate = new DateTime(2021, 12, 18, 12, 15, 43, 746, DateTimeKind.Local).AddTicks(809),
                            Status = 2
                        });
                });

            modelBuilder.Entity("TMS.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.ToTable("tblProjects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Name = "Project 1",
                            Size = 0
                        },
                        new
                        {
                            ProjectId = 2,
                            Name = "Project 2",
                            Size = 2
                        },
                        new
                        {
                            ProjectId = 3,
                            Name = "Project 3",
                            Size = 1
                        });
                });

            modelBuilder.Entity("TMS.Models.EmployeeProject", b =>
                {
                    b.HasOne("TMS.Models.Employee", "Employee")
                        .WithMany("Employeeprojects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Models.Project", "Project")
                        .WithMany("Employeeprojects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TMS.Models.Employee", b =>
                {
                    b.Navigation("Employeeprojects");
                });

            modelBuilder.Entity("TMS.Models.Project", b =>
                {
                    b.Navigation("Employeeprojects");
                });
#pragma warning restore 612, 618
        }
    }
}
