using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercial.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace eCommercial.DataAccess.Concrete.EntityFramework
{
    public class CommercialContext:DbContext
    {
        public CommercialContext(DbContextOptions<CommercialContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(c => new { c.CategoryId, c.ProductId });
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Samsung S5", Url = "samsung-s5", Price = 2000, ImageUrl = "1.jpg", Description = "iyi telefon", IsApproved = true },
                new Product() { Id = 2, Name = "Samsung S6", Url = "samsung-s6", Price = 3000, ImageUrl = "2.jpg", Description = "iyi telefon", IsApproved = false },
                new Product() { Id = 3, Name = "Samsung S7", Url = "samsung-s7", Price = 4000, ImageUrl = "3.jpg", Description = "iyi telefon", IsApproved = true },
                new Product() { Id = 4, Name = "Samsung S8", Url = "samsung-s8", Price = 5000, ImageUrl = "4.jpg", Description = "iyi telefon", IsApproved = false },
                new Product() { Id = 5, Name = "Samsung S9", Url = "samsung-s9", Price = 6000, ImageUrl = "5.jpg", Description = "iyi telefon", IsApproved = true }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Telefon", Url = "telefon" },
                new Category() { Id = 2, Name = "Bilgisayar", Url = "bilgisayar" },
                new Category() { Id = 3, Name = "Elektronik", Url = "elektronik" },
                new Category() { Id = 4, Name = "Beyaz Eşya", Url = "beyaz-esya" }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory() { ProductId = 1, CategoryId = 1 },
                new ProductCategory() { ProductId = 1, CategoryId = 2 },
                new ProductCategory() { ProductId = 1, CategoryId = 3 },
                new ProductCategory() { ProductId = 2, CategoryId = 1 },
                new ProductCategory() { ProductId = 2, CategoryId = 2 },
                new ProductCategory() { ProductId = 2, CategoryId = 3 },
                new ProductCategory() { ProductId = 3, CategoryId = 4 },
                new ProductCategory() { ProductId = 4, CategoryId = 3 },
                new ProductCategory() { ProductId = 5, CategoryId = 3 },
                new ProductCategory() { ProductId = 5, CategoryId = 1 }

           );
        }
    }
}
