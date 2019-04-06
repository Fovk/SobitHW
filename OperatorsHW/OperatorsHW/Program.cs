using System;
using TankLib.WorldOfTanks;

namespace OperatorsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            const int amountOfTanks = 5;

            string pantera = "Pantera";
            string t34 = "T-34";

            Tank[] tanks34 = new Tank[amountOfTanks];
            Tank[] tanksPantera = new Tank[amountOfTanks];
            Console.WriteLine("\nT-34 Tanks: \n");
            for (int i = 0; i < tanks34.Length; i++)
            {
                tanks34[i] = new Tank(t34);
                tanks34[i].Print();
            }

            Console.WriteLine("\nPantera Tanks: \n");
            for (int i = 0; i < tanks34.Length; i++)
            {
                tanksPantera[i] = new Tank(pantera);
                tanksPantera[i].Print();
            }
            Console.WriteLine("\nFights: \n");


            for (int i = 0; i < amountOfTanks; i++)
            {
                string Game = tanks34[i] * tanksPantera[i];
                Console.WriteLine(Game);
            }

            Console.ReadLine();
        }
    }
}
