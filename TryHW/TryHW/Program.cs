using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            string number1, number2;
            Console.WriteLine("Вводите 1 число");
            number1 = Console.ReadLine();
            Console.WriteLine("Вводите 2 число");
            number2 = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(number1) && string.IsNullOrEmpty(number2))
                {
                    throw new ArgumentNullException("Параметры не заданы!");
                }
                int.TryParse(number1, out firstNumber);
                int.TryParse(number2, out secondNumber);
                if (secondNumber == 0)
                {
                    throw new ArgumentException("Делитель равен нулю!");
                }
                else { Console.WriteLine($"Результат деления = {firstNumber / secondNumber}"); }

            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine($"Исключение: {exception.Message}");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"Исключение: {exception.Message}");
            }

            const int arrayLength = 4;
            const int biggerLength = 5;

            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            try
            {
                for (int i = 0; i < biggerLength; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine($"Исключение: {exception.Message}");
            }
            finally { Console.WriteLine("Обработка массива завершена"); }


            Console.ReadLine();
        }
    }
}
