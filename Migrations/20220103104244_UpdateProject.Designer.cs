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
    [Migration("20220103104244_UpdateProject")]
    partial class UpdateProject
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

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("tblEmployees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            FeesPerDay = 15.0,
                            Name = "Employee 1",
                            Photo = "/Images/userprofile.png"
                        },
                        new
                        {
                            EmployeeId = 2,
                            FeesPerDay = 25.0,
                            Name = "Employee 2",
                            Photo = "/Images/employee2.jpg"
                        },
                        new
                        {
                            EmployeeId = 3,
                            FeesPerDay = 10.0,
                            Name = "Employee 3",
                            Photo = "/Images/userprofile.png"
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
                            EndDate = new DateTime(2022, 1, 1, 12, 42, 44, 430, DateTimeKind.Local).AddTicks(9545),
                            ProjectId = 1,
                            StartDate = new DateTime(2021, 12, 27, 12, 42, 44, 429, DateTimeKind.Local).AddTicks(2424),
                            Status = 2
                        },
                        new
                        {
                            EmployeeProjectId = 2,
                            EmployeeId = 2,
                            EndDate = new DateTime(2022, 1, 5, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(179),
                            ProjectId = 2,
                            StartDate = new DateTime(2021, 12, 29, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(168),
                            Status = 1
                        },
                        new
                        {
                            EmployeeProjectId = 3,
                            EmployeeId = 3,
                            EndDate = new DateTime(2022, 1, 10, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(185),
                            ProjectId = 3,
                            StartDate = new DateTime(2022, 1, 5, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(183),
                            Status = 0
                        },
                        new
                        {
                            EmployeeProjectId = 4,
                            EmployeeId = 2,
                            EndDate = new DateTime(2022, 1, 1, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(189),
                            ProjectId = 1,
                            StartDate = new DateTime(2021, 12, 24, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(187),
                            Status = 1
                        },
                        new
                        {
                            EmployeeProjectId = 5,
                            EmployeeId = 1,
                            EndDate = new DateTime(2022, 1, 4, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(193),
                            ProjectId = 3,
                            StartDate = new DateTime(2021, 12, 30, 12, 42, 44, 431, DateTimeKind.Local).AddTicks(191),
                            Status = 2
                        });
                });

            modelBuilder.Entity("TMS.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Icon")
                        .HasColumnType("varbinary(max)");

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
