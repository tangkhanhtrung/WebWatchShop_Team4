﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PesonalShopSolution.Areas.Admin.Data;

namespace PesonalShopSolution.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210518145648_UpdateDb")]
    partial class UpdateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaim");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserRoles", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserToken");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Brand", b =>
                {
                    b.Property<int>("IdBrand")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_brand")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnName("Brand_name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdBrand")
                        .HasName("PK_Trademark");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdCartDetails")
                        .HasColumnName("id_cart_details")
                        .HasColumnType("int");

                    b.Property<int?>("IdProduct")
                        .HasColumnName("id_product")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCartDetails");

                    b.HasIndex("IdProduct");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.CartDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("IdProduct")
                        .HasColumnName("id_product")
                        .HasColumnType("int");

                    b.Property<string>("TotalMoney")
                        .HasColumnName("Total_money")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("IdProduct");

                    b.ToTable("Cart_details");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment1")
                        .HasColumnName("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdProduct")
                        .HasColumnName("id_product")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnName("id_user")
                        .HasColumnType("int")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("IdProduct");

                    b.HasIndex("IdUser");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdOrderDetails")
                        .HasColumnName("id_order_details")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnName("id_user")
                        .HasColumnType("int")
                        .HasMaxLength(128);

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnName("Order_date")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("IdOrderDetails");

                    b.HasIndex("IdUser");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.OrderDetails", b =>
                {
                    b.Property<int>("IdOrderDetails")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_order_details")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("DiscountCode")
                        .HasColumnName("Discount_code")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<int?>("IdProduct")
                        .HasColumnName("id_product")
                        .HasColumnType("int");

                    b.HasKey("IdOrderDetails");

                    b.HasIndex("IdProduct");

                    b.ToTable("Order_details");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DetailDescription")
                        .HasColumnName("Detail_description")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Evaluate")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("IdBrand")
                        .HasColumnName("id_brand")
                        .HasColumnType("int");

                    b.Property<int?>("IdSpecifications")
                        .HasColumnName("id_specifications")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductCode")
                        .HasColumnName("product_code")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnName("product_name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("IdBrand");

                    b.HasIndex("IdSpecifications");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Specification", b =>
                {
                    b.Property<int>("IdSpecifications")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_specifications")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("IdBrand")
                        .HasColumnName("id_brand")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Shape")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Warranty")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdSpecifications");

                    b.HasIndex("IdBrand");

                    b.ToTable("Specification");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetRoleClaims", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserClaims", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserLogins", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserRoles", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PesonalShopSolution.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PesonalShopSolution.Models.AspNetUserToken", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Cart", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.CartDetails", "IdCartDetailsNavigation")
                        .WithMany("Cart")
                        .HasForeignKey("IdCartDetails")
                        .HasConstraintName("FK_Cart_Cart_details");

                    b.HasOne("PesonalShopSolution.Models.Product", "IdProductNavigation")
                        .WithMany("Cart")
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK_Cart_Product");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.CartDetails", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.Product", "IdProductNavigation")
                        .WithMany("CartDetails")
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK_Cart_details_Product");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Comment", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.Product", "IdProductNavigation")
                        .WithMany("Comment")
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK_Comment_Product");

                    b.HasOne("PesonalShopSolution.Models.AspNetUsers", "IdUserNavigation")
                        .WithMany("Comment")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK_Comment_AspNetUsers")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Order", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.OrderDetails", "IdOrderDetailsNavigation")
                        .WithMany("Order")
                        .HasForeignKey("IdOrderDetails")
                        .HasConstraintName("FK_Order_Order_details");

                    b.HasOne("PesonalShopSolution.Models.AspNetUsers", "IdUserNavigation")
                        .WithMany("Order")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK_Order_AspNetUsers")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PesonalShopSolution.Models.OrderDetails", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.Product", "IdProductNavigation")
                        .WithMany("OrderDetails")
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK_Order_details_Product");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Product", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.Brand", "IdBrandNavigation")
                        .WithMany("Product")
                        .HasForeignKey("IdBrand")
                        .HasConstraintName("FK_Product_Trademark");

                    b.HasOne("PesonalShopSolution.Models.Specification", "IdSpecificationsNavigation")
                        .WithMany("Product")
                        .HasForeignKey("IdSpecifications")
                        .HasConstraintName("FK_Product_Specification");
                });

            modelBuilder.Entity("PesonalShopSolution.Models.Specification", b =>
                {
                    b.HasOne("PesonalShopSolution.Models.Brand", "IdBrandNavigation")
                        .WithMany("Specification")
                        .HasForeignKey("IdBrand")
                        .HasConstraintName("FK_Specification_Trademark");
                });
#pragma warning restore 612, 618
        }
    }
}
