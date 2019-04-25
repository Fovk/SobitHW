using System;

namespace JdHw
{
        public class Train : Entity
        {
            public int trainSize { get; set; } = 10;
            public Vagon[] Treno { get; set; }
            public DateTime TimeDeparture { get; set; }
            public DateTime TimeArrival { get; set; }
            public Train()
            {
                Treno = new Vagon[trainSize];
                TimeDeparture = DateTime.Now;
                TimeArrival = DateTime.UtcNow;
                for (int i = 0; i < Treno.Length; i++)
                {
                    Treno[i] = new Vagon();
                    Treno[i].VagonType = VagonType.kupe;
                    Treno[i].Polka = Polka.verhnyualevo;
                }
            }
        }
}