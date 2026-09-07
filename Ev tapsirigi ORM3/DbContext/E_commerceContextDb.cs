using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ev_tapsirigi_ORM3.Table;
using Microsoft.EntityFrameworkCore;

namespace Ev_tapsirigi_ORM3.DbContex
{
    public class E_commerceContextDb : DbContext
    {

        public DbSet<Category>? Categories;
        public DbSet<Product>? Products;
        public DbSet<Order>? Orders;
        public DbSet<Customer>? Customers;
        public DbSet<CustomerAdress>? CustomerAdresses;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
        .ToTable(p => p.HasCheckConstraint("CK_Product_Price", "[Price] > 0"));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-V39TLP5;Database=E_Commerce;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}