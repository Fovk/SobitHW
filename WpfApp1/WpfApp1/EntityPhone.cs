using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class EntityPhone
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string PhoneCode { get; set; } = "+7";
    }
}
