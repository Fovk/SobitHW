using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace IndexatorHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            int insertValue;
            Console.WriteLine("Enter Size of Array");
            int.TryParse(Console.ReadLine(), out arraySize);
            MyArray massiv = new MyArray(arraySize);
            Console.WriteLine("Enter Insert of Value");
            int.TryParse(Console.ReadLine(), out insertValue);
            massiv[insertValue] = insertValue;


            Console.WriteLine("Changed Element Value= " + massiv[insertValue]);
            Console.WriteLine("Changed Element Index " + insertValue);
            massiv.Print();

            Console.ReadLine();
        }
    }
}
