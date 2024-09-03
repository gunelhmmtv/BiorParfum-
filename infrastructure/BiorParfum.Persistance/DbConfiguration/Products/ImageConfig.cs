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
    public class ImageConfig :EfBaseConfigurations<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);
            //builder.Property(x => x.Url)
            //    .IsRequired()
            //    .HasMaxLength(100);
            //builder.Property(x=>x.ContentType) 
            //    .IsRequired()
            //    .HasMaxLength(100);
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Image)
                .HasForeignKey(x => x.ProductId)
                .IsRequired(false);
            builder.HasOne(x => x.User)
                .WithMany(x => x.Image)
                .HasForeignKey(x => x.UserId)
                .IsRequired(false);
        }
    }
}
