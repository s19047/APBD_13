﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Entities;

namespace APBD_13.Migrations
{
    [DbContext(typeof(SweetShopDbContext))]
    [Migration("20200612184004_MadeOrderEmployeeIdNotRequired")]
    partial class MadeOrderEmployeeIdNotRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Entities.Confectionary", b =>
                {
                    b.Property<int>("IdConfectionary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<float>("PricePerIte")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdConfectionary");

                    b.ToTable("Confectionary");

                    b.HasData(
                        new
                        {
                            IdConfectionary = 1,
                            Name = "Chocolate",
                            PricePerIte = 100f,
                            Type = "food"
                        },
                        new
                        {
                            IdConfectionary = 2,
                            Name = "sweets",
                            PricePerIte = 200f,
                            Type = "food"
                        },
                        new
                        {
                            IdConfectionary = 3,
                            Name = "baklawa",
                            PricePerIte = 150f,
                            Type = "food"
                        });
                });

            modelBuilder.Entity("WebApplication1.Entities.Confectionary_Order", b =>
                {
                    b.Property<int>("IdConfection")
                        .HasColumnType("int");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdConfection", "IdOrder");

                    b.HasIndex("IdOrder");

                    b.ToTable("Confectionary_Order");

                    b.HasData(
                        new
                        {
                            IdConfection = 1,
                            IdOrder = 1,
                            Notes = "",
                            Quantity = 2
                        },
                        new
                        {
                            IdConfection = 2,
                            IdOrder = 1,
                            Notes = "",
                            Quantity = 4
                        },
                        new
                        {
                            IdConfection = 3,
                            IdOrder = 2,
                            Notes = "",
                            Quantity = 1
                        },
                        new
                        {
                            IdConfection = 3,
                            IdOrder = 3,
                            Notes = "",
                            Quantity = 50
                        },
                        new
                        {
                            IdConfection = 2,
                            IdOrder = 3,
                            Notes = "",
                            Quantity = 70
                        });
                });

            modelBuilder.Entity("WebApplication1.Entities.Customer", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdClient");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            IdClient = 1,
                            FName = "Ahmad",
                            LName = "Alaziz"
                        },
                        new
                        {
                            IdClient = 2,
                            FName = "Taha",
                            LName = "Savas"
                        },
                        new
                        {
                            IdClient = 3,
                            FName = "Artem",
                            LName = "Rymar"
                        });
                });

            modelBuilder.Entity("WebApplication1.Entities.Employee", b =>
                {
                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdEmployee");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            IdEmployee = 1,
                            FName = "Aghiad",
                            LName = "Alaziz"
                        },
                        new
                        {
                            IdEmployee = 2,
                            FName = "maximus",
                            LName = "Savas"
                        },
                        new
                        {
                            IdEmployee = 3,
                            FName = "Luis",
                            LName = "Rymar"
                        });
                });

            modelBuilder.Entity("WebApplication1.Entities.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAccepted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFinished")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int?>("IdEmployee")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("IdOrder");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdEmployee");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            IdOrder = 1,
                            DateAccepted = new DateTime(1999, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateFinished = new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdClient = 1,
                            IdEmployee = 1,
                            Notes = "sdfdsf"
                        },
                        new
                        {
                            IdOrder = 2,
                            DateAccepted = new DateTime(1998, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateFinished = new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdClient = 1,
                            IdEmployee = 3,
                            Notes = "sdfdsf"
                        },
                        new
                        {
                            IdOrder = 3,
                            DateAccepted = new DateTime(1998, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateFinished = new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdClient = 2,
                            IdEmployee = 2,
                            Notes = "sdfdsf"
                        });
                });

            modelBuilder.Entity("WebApplication1.Entities.Confectionary_Order", b =>
                {
                    b.HasOne("WebApplication1.Entities.Confectionary", "Confectionary")
                        .WithMany("Confectionary_Orders")
                        .HasForeignKey("IdConfection")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Entities.Order", "Order")
                        .WithMany("Confectionary_Orders")
                        .HasForeignKey("IdOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Entities.Order", b =>
                {
                    b.HasOne("WebApplication1.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Entities.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
