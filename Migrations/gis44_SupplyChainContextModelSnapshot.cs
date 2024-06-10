﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Supply_Chain_Backend.Models;

#nullable disable

namespace Supply_Chain_Backend.Migrations
{
    [DbContext(typeof(gis44_SupplyChainContext))]
    partial class gis44_SupplyChainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Cart_Item", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("ProductID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("Quantity")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("ShoppingCartID")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("ShoppingCartID");

                    b.ToTable("Cart Items");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Category", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.OrderHeader", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Adderss")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly?>("OrderDate")
                        .HasColumnType("date");

                    b.Property<decimal?>("OrderTotal")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("PickupEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PickupName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("PickupPhone")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("StripePaymentIntelID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("TotalItems")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("UserID")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("ID");

                    b.ToTable("OrderHeader");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Order_Item", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("OrederHearderID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("ProductID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Quantity")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("ID");

                    b.HasIndex("OrederHearderID");

                    b.HasIndex("ProductID");

                    b.ToTable("Order Items");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Product", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("Category")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("SpecialTag")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("Category");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Shopping_Cart", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("UserID")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("ID");

                    b.ToTable("Shopping Cart");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Store", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("CarNumbers")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("Lat")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<decimal?>("Long")
                        .HasColumnType("decimal(9,6)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Store_Product", b =>
                {
                    b.Property<decimal>("ID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("ProductID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("StoreID")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("StoreID");

                    b.ToTable("Store Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Supply_Chain_Backend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Supply_Chain_Backend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Supply_Chain_Backend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Supply_Chain_Backend.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Cart_Item", b =>
                {
                    b.HasOne("Supply_Chain_Backend.Models.Product", "Product")
                        .WithMany("Cart_Items")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_Cart Items_Product");

                    b.HasOne("Supply_Chain_Backend.Models.Shopping_Cart", "ShoppingCart")
                        .WithMany("Cart_Items")
                        .HasForeignKey("ShoppingCartID")
                        .HasConstraintName("FK_Cart Items_Shopping Cart");

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Order_Item", b =>
                {
                    b.HasOne("Supply_Chain_Backend.Models.OrderHeader", "OrederHearder")
                        .WithMany("Order_Items")
                        .HasForeignKey("OrederHearderID")
                        .HasConstraintName("FK_Order Items_OrderHeader");

                    b.HasOne("Supply_Chain_Backend.Models.Product", "Product")
                        .WithMany("Order_Items")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_Order Items_Product");

                    b.Navigation("OrederHearder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Product", b =>
                {
                    b.HasOne("Supply_Chain_Backend.Models.Category", "CategoryNavigation")
                        .WithMany("Products")
                        .HasForeignKey("Category")
                        .HasConstraintName("FK_Product_Category");

                    b.Navigation("CategoryNavigation");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Store_Product", b =>
                {
                    b.HasOne("Supply_Chain_Backend.Models.Product", "Product")
                        .WithMany("Store_Products")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_Store Product_Product");

                    b.HasOne("Supply_Chain_Backend.Models.Store", "Store")
                        .WithMany("Store_Products")
                        .HasForeignKey("StoreID")
                        .HasConstraintName("FK_Store Product_Stores");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.OrderHeader", b =>
                {
                    b.Navigation("Order_Items");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Product", b =>
                {
                    b.Navigation("Cart_Items");

                    b.Navigation("Order_Items");

                    b.Navigation("Store_Products");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Shopping_Cart", b =>
                {
                    b.Navigation("Cart_Items");
                });

            modelBuilder.Entity("Supply_Chain_Backend.Models.Store", b =>
                {
                    b.Navigation("Store_Products");
                });
#pragma warning restore 612, 618
        }
    }
}
