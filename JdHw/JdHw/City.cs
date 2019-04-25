using System.Collections.Generic;

namespace JdHw
{
    public class City : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Tiket> Tikets { get; set; }
    }
}