using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class City : EntityPhone
    {
        public string Name { get; set; }
        public string PhoneCod { get; set; }
        public City(string name, string code)
        {
            Id = Guid.NewGuid();
            Name = name;
            PhoneCod += PhoneCode;
            PhoneCod += code;
        }
        public City()
        {

        }
    }
}
