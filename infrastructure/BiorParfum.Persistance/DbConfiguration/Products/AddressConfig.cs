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
    public class AddressConfig : EfBaseConfigurations<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
           base.Configure(builder);
            builder.Property(a => a.CityName)
            .IsRequired()
            .HasMaxLength(100);
            builder.Property(a => a.Street)
            .IsRequired()
            .HasMaxLength(200);
            builder.Property(a => a.Country)
            .IsRequired()
            .HasMaxLength(200);


        }
    }
}
