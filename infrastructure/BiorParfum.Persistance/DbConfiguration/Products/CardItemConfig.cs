using BiorParfum.Domain.Entities.Products;
using BiorParfum.Persistance.DbConfiguration.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.DbConfiguration.Products
{
    public class CardItemConfig : EfBaseConfigurations<CardItem>
    {
        public void Configure(EntityTypeBuilder<CardItem> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Quantity)
            .IsRequired();
            builder.HasOne(x => x.Product)
                .WithMany(x => x.CardItem)
                .HasForeignKey(x => x.ProductId);

            
        }
    }
}
