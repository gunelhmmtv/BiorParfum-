using BiorParfum.Application.Interfaces;
using BiorParfum.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.EntityFrameworks.Repositories
{
    public  class EfImageRepository : EfGenericRepository<Image>,IImageRepository
    {
        public EfImageRepository(BiorParfumContext context) : base(context) { }
    }
}
