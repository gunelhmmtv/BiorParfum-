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

        public DbSet<Product> Products => this.Set<Product>();
        public DbSet<Category> Categories => this.Set<Category>();

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
