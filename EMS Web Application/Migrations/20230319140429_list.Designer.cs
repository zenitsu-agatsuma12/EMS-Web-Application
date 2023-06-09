﻿// <auto-generated />
using System;
using EMS_Web_Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS_Web_Application.Migrations
{
    [DbContext(typeof(EMSDBContext))]
    [Migration("20230319140429_list")]
    partial class list
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EMS_Web_Application.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "CSR"
                        });
                });

            modelBuilder.Entity("EMS_Web_Application.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("Full_Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2023, 3, 20, 22, 4, 28, 937, DateTimeKind.Local).AddTicks(2348),
                            DepartmentId = 1,
                            Email = "alvin@gmail.com",
                            Name = "Alvin Root",
                            Phone = "099232312"
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(2023, 3, 21, 22, 4, 28, 937, DateTimeKind.Local).AddTicks(2391),
                            DepartmentId = 2,
                            Email = "trish@gmail.com",
                            Name = "Tricia Tagle",
                            Phone = "099232322312"
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(2023, 3, 22, 22, 4, 28, 937, DateTimeKind.Local).AddTicks(2395),
                            DepartmentId = 3,
                            Email = "Joan@gmail.com",
                            Name = "Joan DC",
                            Phone = "09319232312"
                        });
                });

            modelBuilder.Entity("EMS_Web_Application.Models.Employee", b =>
                {
                    b.HasOne("EMS_Web_Application.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EMS_Web_Application.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
