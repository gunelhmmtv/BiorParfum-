using BiorParfum.Domain.Entities.Products;
using BiorParfum.Persistance.DbConfiguration.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.DbConfiguration.Products
{
    public class OrderConfig : EfBaseConfigurations<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(x=>x.Quantity)
                .IsRequired();
            builder.Property(x=>x.CommitOrder) 
                .IsRequired();
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Order)
                .HasForeignKey(x => x.CustomerId);
            builder.HasMany(x=>x.ProductOrder)
                .WithOne(x=>x.Order)
                .HasForeignKey(x => x.OrderId);   
        }
    }
}
