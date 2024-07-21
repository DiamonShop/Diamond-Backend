﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diamond.Entities.Migrations
{
    [DbContext(typeof(DiamondDbContext))]
    [Migration("20240721175431_DbInit")]
    partial class DbInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diamond.Entities.Data.Diamonds", b =>
                {
                    b.Property<int>("DiamondID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiamondID"));

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<decimal>("Carat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Clarity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cut")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("DiameterMM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DiamondID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("Diamonds");
                });

            modelBuilder.Entity("Diamond.Entities.Data.Jewelry", b =>
                {
                    b.Property<int>("JewelryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JewelryID"));

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("JewelrySettingID")
                        .HasColumnType("int");

                    b.Property<int>("MainDiamondID")
                        .HasColumnType("int");

                    b.Property<int>("MainDiamondQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SideDiamondID")
                        .HasColumnType("int");

                    b.Property<int>("SideDiamondQuantity")
                        .HasColumnType("int");

                    b.HasKey("JewelryID");

                    b.HasIndex("CategoryId");

                    b.HasIndex("JewelrySettingID");

                    b.HasIndex("MainDiamondID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.HasIndex("SideDiamondID");

                    b.ToTable("Jewelry");
                });

            modelBuilder.Entity("Diamond.Entities.Data.JewelrySettings", b =>
                {
                    b.Property<int>("JewelrySettingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JewelrySettingID"));

                    b.Property<int>("BasePrice")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("JewelrySettingID");

                    b.ToTable("JewelrySetting");
                });

            modelBuilder.Entity("Diamond.Entities.Data.JewelrySize", b =>
                {
                    b.Property<int>("JewelrySizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JewelrySizeID"));

                    b.Property<int>("JewelryID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("JewelrySizeID");

                    b.HasIndex("JewelryID");

                    b.ToTable("JewelrySizes");
                });

            modelBuilder.Entity("Diamond.Entities.Data.MainDiamond", b =>
                {
                    b.Property<int>("MainDiamondID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainDiamondID"));

                    b.Property<string>("MainDiamondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("MainDiamondID");

                    b.ToTable("MainDiamonds");
                });

            modelBuilder.Entity("Diamond.Entities.Data.SideDiamond", b =>
                {
                    b.Property<int>("SideDiamondID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SideDiamondID"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("SideDiamondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SideDiamondID");

                    b.ToTable("SideDiamonds");
                });

            modelBuilder.Entity("DiamondShop.Data.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DiamondShop.Data.Certification", b =>
                {
                    b.Property<int>("CertificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificationID"));

                    b.Property<DateTime>("CertificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificationDetails")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DiamondID")
                        .HasColumnType("int");

                    b.HasKey("CertificationID");

                    b.HasIndex("DiamondID")
                        .IsUnique();

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("DiamondShop.Data.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FeedbackId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("DiamondShop.Data.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("CancelReason")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNote")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DiamondShop.Data.OrderDetail", b =>
                {
                    b.Property<string>("OrderDetailId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DiamondShop.Data.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MarkupPrice")
                        .HasColumnType("int");

                    b.Property<decimal>("MarkupRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DiamondShop.Data.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DiamondShop.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LoyaltyPoints")
                        .HasColumnType("int");

                    b.Property<string>("NumberPhone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DiamondShop.Data.Warranty", b =>
                {
                    b.Property<int>("WarrantyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarrantyId"));

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WarrantyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Warranties");
                });

            modelBuilder.Entity("Diamond.Entities.Data.Diamonds", b =>
                {
                    b.HasOne("DiamondShop.Data.Product", "Product")
                        .WithOne("Diamond")
                        .HasForeignKey("Diamond.Entities.Data.Diamonds", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Diamond.Entities.Data.Jewelry", b =>
                {
                    b.HasOne("DiamondShop.Data.Category", "Category")
                        .WithMany("Jewelry")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diamond.Entities.Data.JewelrySettings", "JewelrySetting")
                        .WithMany("Jewelry")
                        .HasForeignKey("JewelrySettingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diamond.Entities.Data.MainDiamond", "MainDiamond")
                        .WithMany("JewelrySizes")
                        .HasForeignKey("MainDiamondID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiamondShop.Data.Product", "Product")
                        .WithOne("Jewelry")
                        .HasForeignKey("Diamond.Entities.Data.Jewelry", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diamond.Entities.Data.SideDiamond", "SideDiamond")
                        .WithMany("Jewelry")
                        .HasForeignKey("SideDiamondID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("JewelrySetting");

                    b.Navigation("MainDiamond");

                    b.Navigation("Product");

                    b.Navigation("SideDiamond");
                });

            modelBuilder.Entity("Diamond.Entities.Data.JewelrySize", b =>
                {
                    b.HasOne("Diamond.Entities.Data.Jewelry", "Jewelry")
                        .WithMany("JewelrySizes")
                        .HasForeignKey("JewelryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("DiamondShop.Data.Certification", b =>
                {
                    b.HasOne("Diamond.Entities.Data.Diamonds", "Diamond")
                        .WithOne("Certification")
                        .HasForeignKey("DiamondShop.Data.Certification", "DiamondID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diamond");
                });

            modelBuilder.Entity("DiamondShop.Data.Feedback", b =>
                {
                    b.HasOne("DiamondShop.Data.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiamondShop.Data.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiamondShop.Data.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiamondShop.Data.Order", b =>
                {
                    b.HasOne("DiamondShop.Data.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiamondShop.Data.OrderDetail", b =>
                {
                    b.HasOne("DiamondShop.Data.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DiamondShop.Data.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DiamondShop.Data.User", b =>
                {
                    b.HasOne("DiamondShop.Data.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DiamondShop.Data.Warranty", b =>
                {
                    b.HasOne("DiamondShop.Data.Product", "Product")
                        .WithMany("Warranties")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiamondShop.Data.User", "User")
                        .WithMany("Warranties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Diamond.Entities.Data.Diamonds", b =>
                {
                    b.Navigation("Certification")
                        .IsRequired();
                });

            modelBuilder.Entity("Diamond.Entities.Data.Jewelry", b =>
                {
                    b.Navigation("JewelrySizes");
                });

            modelBuilder.Entity("Diamond.Entities.Data.JewelrySettings", b =>
                {
                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("Diamond.Entities.Data.MainDiamond", b =>
                {
                    b.Navigation("JewelrySizes");
                });

            modelBuilder.Entity("Diamond.Entities.Data.SideDiamond", b =>
                {
                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("DiamondShop.Data.Category", b =>
                {
                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("DiamondShop.Data.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DiamondShop.Data.Product", b =>
                {
                    b.Navigation("Diamond")
                        .IsRequired();

                    b.Navigation("Feedbacks");

                    b.Navigation("Jewelry")
                        .IsRequired();

                    b.Navigation("OrderDetails");

                    b.Navigation("Warranties");
                });

            modelBuilder.Entity("DiamondShop.Data.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DiamondShop.Data.User", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Orders");

                    b.Navigation("Warranties");
                });
#pragma warning restore 612, 618
        }
    }
}
