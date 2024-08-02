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
    public class CountryConfig : EfBaseConfigurations<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);
            builder.Property(a => a.Name)
             .IsRequired()
             .HasMaxLength(100);
          

        }
    }
}
