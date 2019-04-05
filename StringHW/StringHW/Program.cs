using System;
namespace StringHW
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вводите символы и пробелы, а затем в конце поставьте точку: ");
            int symbol = 0;
            int countSpaces = 0;
            while (symbol != '.')
            {
                symbol = Console.Read();
                if (symbol == ' ')
                {
                    countSpaces++;
                }
            }
            string amountSpaces = $"Кол-во пробелов: {countSpaces}";
            Console.WriteLine(amountSpaces);

            Console.WriteLine("Вводите 6-значный билет: ");
            int bilet = Convert.ToInt32(Console.ReadLine());
            const int ten = 10, hundred = 100, thousand = 1000;
            if (bilet > 99999 && bilet < 1000000)
            {
                Console.WriteLine("Число 6-значное!");

                int sumOfFirstPart = ((bilet / thousand) % ten)
                    + ((bilet / (thousand * ten)) % ten)
                    + ((bilet / (thousand * hundred)) % ten);

                int sumOfSecondPart = (bilet % ten)
                    + ((bilet % hundred) / ten)
                    + (((bilet % thousand) / hundred));

                Console.WriteLine("Сумма первой половины: " + sumOfFirstPart);
                Console.WriteLine("Сумма второй половины: " + sumOfSecondPart);

                if (sumOfFirstPart == sumOfSecondPart)
                {
                    Console.WriteLine("Билет счаслтивый!");
                }
                else { Console.WriteLine("Билет не счастливый!"); }
            }
            else
            {
                Console.WriteLine("Билет не 6-значное!");



                Console.WriteLine("Введите строку для перевода в нижний регистр: ");
                string registr = Console.ReadLine();
                string lowRegistr = "Нижний регистр: " + registr.ToLower();
                Console.WriteLine("Введите строку для перевода в верхний регистр : ");
                registr = Console.ReadLine();
                Console.WriteLine(lowRegistr);
                string highRegistr = "Верхгий регистр: " + registr.ToUpper();
                Console.WriteLine(highRegistr);



                Console.Write("\nВведите первое число: ");
                int numberA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int numberB = Convert.ToInt32(Console.ReadLine());

                if (numberA > numberB)
                {
                    int temp = numberA;
                    numberA = numberB;
                    numberB = temp;
                }
                while (numberA <= numberB)
                {
                    for (int i = 0; i <= numberA; i++)
                    {
                        Console.Write(numberA);
                        Console.Write(' ');
                    }
                    numberA++;
                    Console.Write("\n");
                }


                Console.WriteLine("\nВведите натруральное число для перевертывания: ");
                int number = Convert.ToInt32(Console.ReadLine());
                string reverseNumber = null;
                if (number > 0)
                {
                    Console.Write("Перевернуть: ");
                    while (number > 0)
                    {
                        reverseNumber += number % ten;
                        number = number / ten;
                    }
                    Console.WriteLine(reverseNumber);
                }
                else { Console.WriteLine("Число не натуральное!"); }

                Console.ReadKey();
            }
        }
    }
}
