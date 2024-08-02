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
    public class CustomerConfig : EfBaseConfigurations<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x=>x.PhoneNumber) 
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
