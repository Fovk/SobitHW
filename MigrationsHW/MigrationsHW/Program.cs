using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добавление посетиеля");
            Visitor visitor = new Visitor();
            Console.WriteLine("Введите ФИО");
            visitor.FullName = Console.ReadLine();
            Console.WriteLine("Введите ИИН");
            visitor.IIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время входа посетителя");
            try
            {
                visitor.DateEnter = Convert.ToDateTime(Console.ReadLine());
            }
            catch(Exception e)
            {
                visitor.DateEnter = DateTime.Now;
            }
            Console.WriteLine("Введите время выхода посетителя");
            try
            {
                visitor.DateExit = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception e)
            {
                visitor.DateExit = null;
            }
            Console.WriteLine("Введите цель визита");
            visitor.AimVisit = Console.ReadLine();
            using (var context = new VisitorContext())
            {
                context.Visitors.Add(visitor);
                context.SaveChanges();
                //Console.WriteLine(context.Database.ExecuteSqlCommand("select * from dbo.Visitors")); 
            }

        }      
    }
}
