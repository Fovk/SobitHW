using System;
using System.Linq;

namespace EnumHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во сотрудников");
            int amountOfWorkers = Convert.ToInt32(Console.ReadLine());

            Office[] office = new Office[amountOfWorkers];
            for (int i = 0; i < office.Length; i++)
            {
                office[i].Init();
            }
            for (int i = 0; i < office.Length; i++)
            {
                office[i].Print();
            }

            if (Array.Exists(office, i => i.Position == Position.manager) && Array.Exists(office, j => j.Position == Position.clerk))
            {
                Office[] managers = Array.FindAll(office,
                i => i.Position == Position.manager);
                Office[] Clerks = Array.FindAll(office,
                j => j.Position == Position.clerk);
                Office[] bigSalaryManagers = Array.FindAll(managers,
                        i => i.Salary > Clerks.Max(j => j.Salary));
                Array.Sort(bigSalaryManagers);
                for (int i = 0; i < bigSalaryManagers.Length; i++)
                {
                    bigSalaryManagers[i].Print();
                }
            }
            else { Console.WriteLine("Нету клерков или менеджеров"); }

            /*
			c.	распечатать информацию обо всех сотрудниках, принятых на работу
            позже босса, отсортированную в алфавитном порядке по фамилии сотрудника.
			*/
            if (Array.Exists(office, i => i.Position == Position.boss))
            {
                Office boss = Array.Find(office, i => i.Position == Position.boss);
                Office[] afterBoss = Array.FindAll(office, i => i.DateTimeEmployment > boss.DateTimeEmployment);
                Array.Sort(afterBoss);
                for (int i = 0; i < afterBoss.Length; i++)
                {
                    afterBoss[i].Print();
                }
            }
            else { Console.WriteLine("Нету босса"); }


            const int numberStudents = 4;
            Student[] students = new Student[numberStudents];
            const int minSalary = 42500;
            students[0] = new Student("Kuan Li", "1", 5, 200000, Sex.male, Education.fullTime);
            students[1] = new Student("Hue Li", "2", 4, 300000, Sex.male, Education.distance);
            students[2] = new Student("J Ni", "1", 5, 150000, Sex.female, Education.fullTime);
            students[3] = new Student("Jak Ma", "2", 3, 80000, Sex.male, Education.distance);
            Student[] minIncomeStudent = Array.FindAll(students, x => x.Income < minSalary + minSalary);
            foreach (var i in minIncomeStudent)
            {
                i.Print();
            }
            Student[] otherStudents = Array.FindAll(students, x => x.Income > minSalary + minSalary);
            Array.Sort(otherStudents, delegate (Student x, Student y)
            {
                return y.Mark.CompareTo(x.Mark);
            });
            foreach (var i in otherStudents)
            {
                i.Print();
            }
            Console.ReadLine();
        }
    }
}