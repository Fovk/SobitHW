using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz29._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1  2  3");
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
            int rasstoyanie;
            rasstoyanie = int.Parse(Console.ReadLine());
            int metry;
            metry = rasstoyanie / 100;
            int days = 234;
            int weeks = days / 7;
            int decimalInt;
            decimalInt = Convert.ToInt16(Console.ReadLine());
            int decyatok, cifra;
            decyatok = decimalInt / 10;
            cifra = decimalInt - decyatok * 10;
            Console.WriteLine($"{decyatok}, {cifra}, {decyatok * cifra}, {decyatok + cifra}");
            bool boolA = true, boolB = false, boolC = false;
            Console.WriteLine($"{boolA || boolB}");
            Console.WriteLine($"{boolA && boolB}");
            Console.WriteLine($"{boolB && boolC}");
            double squareSide, circleSide;
            squareSide = double.Parse(Console.ReadLine());
            circleSide = double.Parse(Console.ReadLine());
            double Pi = 3.14;
            double squareArea, circleArea;
            squareArea = squareSide * squareSide;
            circleArea = Pi*Math.Pow(circleSide,2);
            if(squareArea>= circleArea) Console.WriteLine(squareArea);
            else Console.WriteLine(circleArea);
            int mass1Body, mass2Body, volume1Body, volume2Body;
            double density1Body, density2Body;
            mass1Body = Convert.ToInt16(Console.ReadLine());
            mass2Body = Convert.ToInt16(Console.ReadLine());
            volume1Body = Convert.ToInt16(Console.ReadLine());
            volume2Body = Convert.ToInt16(Console.ReadLine());
            density1Body = mass1Body / volume1Body;
            density2Body = mass2Body / volume2Body;
            if (density1Body >= density2Body) Console.WriteLine(density1Body);
            else Console.WriteLine(density2Body);
            int napr1Body, napr2Body, sopr1Body, sopr2Body;
            double tok1Body, tok2Body;
            napr1Body = Convert.ToInt16(Console.ReadLine());
            napr2Body = Convert.ToInt16(Console.ReadLine());
            sopr1Body = Convert.ToInt16(Console.ReadLine());
            sopr2Body = Convert.ToInt16(Console.ReadLine());
            tok1Body = napr1Body / sopr1Body;
            tok2Body = napr2Body / sopr2Body;
            if (tok1Body <= tok2Body) Console.WriteLine(tok1Body);
            else Console.WriteLine(tok2Body);
            for(int i = 20; i< 35; i++)
            {
                Console.WriteLine(i);
            }
            int intB, intA;
            intB = Convert.ToInt16(Console.ReadLine());
            intA = Convert.ToInt16(Console.ReadLine());
            if (intB > 10)
            {
                for (int i = 10; i <= intB; i++)
                {
                    Console.WriteLine(Math.Pow(i,2));
                }
            }
            if (intA < 50)
            {
                for (int i = intA; i <= 50; i++)
                {
                    Console.WriteLine(Math.Pow(i, 3));
                }
            }
            if (intB > intA)
            {
                for (int i = intA; i <= intB; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
