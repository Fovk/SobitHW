using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEF
{
    public class Basket : Entity
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Guid UserId { get; set; }
    }
}
