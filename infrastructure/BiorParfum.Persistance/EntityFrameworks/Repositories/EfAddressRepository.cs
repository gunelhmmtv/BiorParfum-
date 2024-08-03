using BiorParfum.Application.Interfaces;
using BiorParfum.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.EntityFrameworks.Repositories
{
    public class EfAddressRepository : EfGenericRepository<Address>, IAddressRepository
    {
        public EfAddressRepository(BiorParfumContext context) : base(context) { }
    }
}
