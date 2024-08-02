using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<CardItem> CardItem { get; set; }
        public ICollection<Review> Review { get;}
        public ICollection<ProductOrder> ProductOrder { get; set; }
        public ICollection<Image> Image { get; set; }


    }
}
