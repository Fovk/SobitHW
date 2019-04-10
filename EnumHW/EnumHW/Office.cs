using System;
namespace EnumHW
{
    public enum Position
    {
        clerk = 1,
        manager = 2,
        boss = 3
    }
    public struct Office
    {
        //const int amountofDots = 3;
        const int minWorkPosition = 1;
        const int maxWorkPosition = 3;
        public string Name { get; set; }
        public int Salary { get; set; }
        public Position Position { get; set; }
        public DateTime DateTimeEmployment { get; set; }

        public void Init()
        {
            Console.WriteLine("Введите имя:");
            Name = Console.ReadLine();
            Console.WriteLine("Введите зарплату:");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите должность 1(клерк), 2(менеджер), 3(директор):");

            try
            {
                int key = Convert.ToInt32(Console.ReadLine());
                if (key < minWorkPosition && key > maxWorkPosition)
                {
                    throw new Exception("Не правильная должность!");
                }
                else
                {
                    Position = (Position)key;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("Введите дату принятия на работу, через '.'(точку)  :");

            DateTimeEmployment = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\n");
        }
        public void Print()
        {
            Console.WriteLine($"Имя :: {Name}; Зарплата : {Salary}; Должность : {Position} Дата начала работы : {DateTimeEmployment.ToString()}");
            Console.WriteLine(" ");
        }
    }
}

