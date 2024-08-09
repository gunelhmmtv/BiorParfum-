using BiorParfum.Domain.Entities.Accounts;
using BiorParfum.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.EntityFrameworks
{
    public class BiorParfumContext : DbContext
    {
        public BiorParfumContext(DbContextOptions<BiorParfumContext> optionsBuilder)
            :base(optionsBuilder) 
        {
            
        }
        public DbSet<User> Users => this.Set<User>();
        public DbSet<Role> Roles => this.Set<Role>();
        public DbSet<UserDetail> UserDetails => this.Set<UserDetail>();
        public DbSet<UserRole> UserRoles => this.Set<UserRole>();
        public DbSet<Product> Products => this.Set<Product>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<Address> Addresss => this.Set<Address>();
        public DbSet<CardItem> CardItems => this.Set<CardItem>();
        public DbSet<Country> Countries => this.Set<Country>();
        public DbSet<Customer> Customers => this.Set<Customer>();
        public DbSet<Image> Images => this.Set<Image>();
        public DbSet<Order> Orders => this.Set<Order>();
        public DbSet<Review> Reviews => this.Set<Review>();
        public DbSet<ProductOrder> ProductOrders => this.Set<ProductOrder>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Category>()
                .HasData(
                    new Category { Id = 1, Value = "Perfumes" },
                    new Category { Id = 2, Value = "Fragrances" }
                  
                );


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
