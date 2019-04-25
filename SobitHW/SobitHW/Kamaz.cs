using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobitHW
{
    public class Kamaz : Car
    {
        public int MaxSpeed { get; set; }
        Random random;
        public event ReporterPostionDelegate Finish;
        public int SecondForRace { get; set; } = 0;
        public Kamaz(int maxspeed)
        {
            MaxSpeed = maxspeed;
            random = new Random();
            Finish += reporterDelegate;
        }
        private void FibishMessage(string tmp)
        {
            Console.WriteLine(tmp);
        }
        public override int Move(int x, int y)
        {
            while (x <= y)
            {
                Speed = random.Next(MaxSpeed);
                x += Speed;
                SecondForRace += 1;
            }
            string tmp = $"Car came for finish for {SecondForRace} seconds {Name}";
            Finish += FibishMessage;
            Finish(tmp);
            return SecondForRace;
        }
    }
}
