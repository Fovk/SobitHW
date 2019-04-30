using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsDbUpHW
{
    public class Comment : Entity
    {
        public string Content { get; set; }
        public Guid NewsId { get; set; }
        public string UserLogin { get; set; }
        public virtual User User { get; set; }
        public virtual News News { get; set; }
    }
}
