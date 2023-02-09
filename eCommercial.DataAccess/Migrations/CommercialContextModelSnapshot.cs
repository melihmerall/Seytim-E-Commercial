﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommercial.DataAccess.Concrete.EntityFramework;

#nullable disable

namespace eCommercial.DataAccess.Migrations
{
    [DbContext(typeof(CommercialContext))]
    partial class CommercialContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eCommercial.Entities.Concrete.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 568, DateTimeKind.Local).AddTicks(9977),
                            Name = "Telefon",
                            Status = false,
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 569, DateTimeKind.Local).AddTicks(84),
                            Name = "Bilgisayar",
                            Status = false,
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 569, DateTimeKind.Local).AddTicks(87),
                            Name = "Elektronik",
                            Status = false,
                            Url = "elektronik"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 569, DateTimeKind.Local).AddTicks(88),
                            Name = "Beyaz Eşya",
                            Status = false,
                            Url = "beyaz-esya"
                        });
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConversationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderState")
                        .HasColumnType("int");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHome")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 568, DateTimeKind.Local).AddTicks(9770),
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "iyi telefon",
                            ImageUrl = "1.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Samsung S5",
                            Price = 2000.0,
                            Status = false,
                            Url = "samsung-s5"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 568, DateTimeKind.Local).AddTicks(9806),
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "iyi telefon",
                            ImageUrl = "2.jpg",
                            IsApproved = false,
                            IsHome = false,
                            Name = "Samsung S6",
                            Price = 3000.0,
                            Status = false,
                            Url = "samsung-s6"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 568, DateTimeKind.Local).AddTicks(9807),
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "iyi telefon",
                            ImageUrl = "3.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Samsung S7",
                            Price = 4000.0,
                            Status = false,
                            Url = "samsung-s7"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 568, DateTimeKind.Local).AddTicks(9808),
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "iyi telefon",
                            ImageUrl = "4.jpg",
                            IsApproved = false,
                            IsHome = false,
                            Name = "Samsung S8",
                            Price = 5000.0,
                            Status = false,
                            Url = "samsung-s8"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 2, 9, 3, 24, 40, 568, DateTimeKind.Local).AddTicks(9810),
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "iyi telefon",
                            ImageUrl = "5.jpg",
                            IsApproved = true,
                            IsHome = false,
                            Name = "Samsung S9",
                            Price = 6000.0,
                            Status = false,
                            Url = "samsung-s9"
                        });
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 5
                        });
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.CartItem", b =>
                {
                    b.HasOne("eCommercial.Entities.Concrete.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommercial.Entities.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Image", b =>
                {
                    b.HasOne("eCommercial.Entities.Concrete.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsId");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.OrderItem", b =>
                {
                    b.HasOne("eCommercial.Entities.Concrete.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommercial.Entities.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.ProductCategory", b =>
                {
                    b.HasOne("eCommercial.Entities.Concrete.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommercial.Entities.Concrete.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("eCommercial.Entities.Concrete.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
