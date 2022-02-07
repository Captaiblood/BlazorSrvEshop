using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrvEShopModels.SrvModels
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public IList<ProductProperties> productProperties { get; set; } = new List<ProductProperties>();
    }
}
