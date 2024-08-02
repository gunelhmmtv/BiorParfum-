using BiorParfum.Domain.Entities.Products;
using BiorParfum.Persistance.DbConfiguration.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.DbConfiguration.Products
{
    public class ProductConfig : EfBaseConfigurations<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {

            base.Configure(builder);
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Price);
            builder.Property(x => x.Weight);


            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);
           builder.HasMany(x=>x.ProductOrder)
                .WithOne(x=>x.Product)
                .HasForeignKey(x => x.ProductId);
            





        }
    }
}
