﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zakázky;

#nullable disable

namespace Zakázky.Migrations
{
    [DbContext(typeof(MainDBContext))]
    [Migration("20250408201805_DBMigration110")]
    partial class DBMigration110
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Zakázky.DB_Class.AdressList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID");

                    b.ToTable("AdressList");
                });

            modelBuilder.Entity("Zakázky.DB_Class.ContactList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID");

                    b.ToTable("ContactList");
                });

            modelBuilder.Entity("Zakázky.DB_Class.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContactID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Zakázky.DB_Class.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("CreadtedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustumerID")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeTookOverId")
                        .HasColumnType("int");

                    b.Property<decimal?>("EstimatedTotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("OrderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNote")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("OrderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CustumerID");

                    b.HasIndex("EmployeeTookOverId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Zakázky.DB_Class.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("OrderItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderItemNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderItemQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Zakázky.DB_Class.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Zakázky.DB_Class.AdressList", b =>
                {
                    b.HasOne("Zakázky.DB_Class.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Zakázky.DB_Class.ContactList", b =>
                {
                    b.HasOne("Zakázky.DB_Class.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Zakázky.DB_Class.Employee", b =>
                {
                    b.HasOne("Zakázky.DB_Class.ContactList", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactID");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Zakázky.DB_Class.Order", b =>
                {
                    b.HasOne("Zakázky.DB_Class.Subject", "Custumer")
                        .WithMany()
                        .HasForeignKey("CustumerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zakázky.DB_Class.Employee", "EmployeeTookOver")
                        .WithMany()
                        .HasForeignKey("EmployeeTookOverId");

                    b.Navigation("Custumer");

                    b.Navigation("EmployeeTookOver");
                });

            modelBuilder.Entity("Zakázky.DB_Class.OrderItem", b =>
                {
                    b.HasOne("Zakázky.DB_Class.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
