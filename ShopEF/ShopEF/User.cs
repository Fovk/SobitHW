
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShopEF
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Basket Basket { get; set; } = new Basket();
    }
}