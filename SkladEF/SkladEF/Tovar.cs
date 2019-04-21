using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladEF
{
    public class Tovar
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public Tovar()
        {
            Id = Guid.NewGuid();
        }
    }
}
