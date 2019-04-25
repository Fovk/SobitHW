using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobitHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeep jeep = new Jeep(12);
            SportCar sportCar = new SportCar(14);
            Kamaz kamaz = new Kamaz(9);
            Sedan sedan = new Sedan(11);
            jeep.Finish += jeep.reporterDelegate;
            sportCar.Finish += sportCar.reporterDelegate;
            sportCar.Name = "sportCar";
            jeep.Name = "jeep";
            kamaz.Name = "kamaz";
            sedan.Name = "sedan";
            Rally rally = new Rally();
            rally.Cars.Add(jeep);
            rally.Cars.Add(sportCar);
            rally.Cars.Add(sedan);
            rally.Cars.Add(kamaz);
            rally.StartPostion=0;
            rally.FinishPosition = 100;
            rally.Race();
            Console.ReadLine();
        }
    }
}
