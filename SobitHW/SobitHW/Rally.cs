using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobitHW
{
    public class Rally
    {
        public int StartPostion { get; set; }
        public int FinishPosition { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<int> FinishSeconds { get; set; } = new List<int>();
        delegate void StartRace(int x, int y);
        public void Race()
        {
            StartRace race;
            foreach(Car i in Cars)
            {
                //string tmp;
                FinishSeconds.Add(i.Move(StartPostion, FinishPosition));
                //tmp = i.Move(StartPostion, FinishPosition).ToString();
                //i.Finish(tmp);
            }
            Console.WriteLine("Winner "+FinishSeconds.Min());
        }
    }
}
