using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class UserPhone : City
    {
        public string Phone { get; set; }
        public string Comment { get; set; }
        public UserPhone(string phone,string comment)
        {
            Id = Guid.NewGuid();
            Phone += PhoneCod;
            Phone += phone;
            Comment = comment;
        }
        public UserPhone()
        {

        }
    }
}
