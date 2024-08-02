using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Products
{
    public class CardItem : BaseEntity
    {
        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
