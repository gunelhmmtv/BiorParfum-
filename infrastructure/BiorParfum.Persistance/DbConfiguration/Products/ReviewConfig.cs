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
    public class ReviewConfig : EfBaseConfigurations<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Comment)
                .IsRequired()
                .HasMaxLength(250);
            builder.Property(x => x.ReviewPoint)
                .IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(x => x.Review)
                .HasForeignKey(x => x.UserId);
            builder.HasOne(x=>x.Product)
                .WithMany(x=>x.Review)
                .HasForeignKey(x => x.ProductId);

        }
    }
}
