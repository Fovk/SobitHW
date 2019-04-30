using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsDbUpHW
{
    public class News : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserLogin { get; set; }
        public virtual User User { get; set; }
    }
}
