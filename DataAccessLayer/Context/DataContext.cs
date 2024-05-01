using DataAccessLayer.Migrations;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public partial class DataContext : DbContext
    {
        public DataContext() : base("name=FinalProject")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ImportDetail> ImportDetails { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PictureProduct> PictureProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.Brand_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customers_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.DiscountCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Employee_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PassWordAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ImportDetail>()
                .Property(e => e.Import_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ImportDetail>()
                .Property(e => e.Product_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import>()
                .Property(e => e.Import_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import>()
                .Property(e => e.Supplier_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import>()
                .HasMany(e => e.ImportDetails)
                .WithRequired(e => e.Import)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Order_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Product_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Order_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Customers_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Employee_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.DiscountCode)
                .IsUnicode(false);

            modelBuilder.Entity<PictureProduct>()
                .Property(e => e.PictureName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Brand_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ImportDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);
        }
    }
}
