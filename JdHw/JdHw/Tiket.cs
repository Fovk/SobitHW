using System;
using System.Collections.Generic;

namespace JdHw
{
    public class Tiket : Entity
    {
        public int Price { get; set; }
        public Guid DestinationId { get; set; }
        public Guid DepartureId { get; set; }
        public Guid UserId { get; set; }
        public Guid TrainId { get; set; }
        public virtual ICollection<City> cities { get; set; }
        public virtual User User { get; set; }
        public virtual Train Train { get; set; }
    }
}