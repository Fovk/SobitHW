using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsHW
{
    public class Visitor
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public int IIN { get; set; }
        public DateTime DateEnter { get; set; } = DateTime.Now;
        public DateTime? DateExit { get; set; }
        public string AimVisit { get; set; }
        public Visitor()
        {
            ID = Guid.NewGuid();
        }
    }
}
