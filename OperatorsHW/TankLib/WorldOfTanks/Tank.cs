using System;
using System.Threading;

namespace TankLib.WorldOfTanks
{
    public class Tank
    {
        private string _tankName;
        private int _ammunition;
        private int _armor;
        private int _agility;

        public Tank(string tankName)
        {
            Thread.Sleep(500);
            Random random = new Random();
            _tankName = tankName;
            _ammunition = random.Next(0, 100);
            _armor = random.Next(0, 100);
            _agility = random.Next(0, 100);
        }
        public void Print()
        {
            Console.WriteLine($"Name       : {_tankName}\nAmmunition : {_ammunition}\nArmor      : {_armor}\nAgility    : {_agility}");
            Console.WriteLine("--------------------");
        }

        public static string operator *(Tank firstTank, Tank secondTank)
        {
            int Counter = 0;
            try
            {
                if (firstTank._tankName == null || secondTank._tankName == null)
                    throw new Exception("Названия танков не заданы!");
                else
                {
                    if (firstTank._ammunition > secondTank._ammunition)
                    {
                        Counter++;
                    }
                    if (firstTank._armor > secondTank._armor)
                    {
                        Counter++;
                    }
                    if (firstTank._agility > secondTank._agility)
                    {
                        Counter++;
                    }
                    if (Counter > 1) { return "T-34 win!\n"; }
                    else { return "Pantera win!\n"; }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Исключение: {exception.Message}");
                return "Танк не найден!\n";
            }
        }
    }
}
