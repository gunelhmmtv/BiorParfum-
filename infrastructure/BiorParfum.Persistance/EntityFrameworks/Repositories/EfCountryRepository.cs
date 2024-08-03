using BiorParfum.Application.Interfaces;
using BiorParfum.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.EntityFrameworks.Repositories
{
    public class EfCountryRepository : EfGenericRepository<Country>,ICountryRepository
    {
        EfCountryRepository(BiorParfumContext context) : base(context) { }
    }
}
