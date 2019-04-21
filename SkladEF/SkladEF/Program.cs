using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add tovar");
            Tovar tovar = new Tovar();
            Console.WriteLine("Enter name tovar");
            tovar.Name = Console.ReadLine();
            Console.WriteLine("Enter price of tovar");
            tovar.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of tovar");
            tovar.Amount = int.Parse(Console.ReadLine());
            using (var context = new SkladContext())
            {
                context.Tovars.Add(tovar);
                context.SaveChanges();
            }
            Console.WriteLine("Enter name tovar for find it");
            Tovar findTovar = new Tovar();
            findTovar.Id = Guid.Empty;
            findTovar.Name = Console.ReadLine();
            List<Tovar> tovars = new List<Tovar>();
            using (var context = new SkladContext())
            {
                tovars = context.Tovars.ToList();
            }
            foreach (Tovar t in tovars)
            {
                if (t.Name.Equals(findTovar.Name) == true)
                {
                    findTovar.Id = t.Id;
                }
            }
            if (findTovar.Id != Guid.Empty)
            {
                Console.WriteLine("Enter price of tovar");
                findTovar.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount of tovar");
                findTovar.Amount = int.Parse(Console.ReadLine());
            }
            else Console.WriteLine("Tovar dont exist");
            using (var context = new SkladContext())
            {
                var findTovars = context.Tovars;
                foreach (Tovar t in findTovars)
                {
                    if (t.Id == findTovar.Id)
                    {
                        t.Price = findTovar.Price;
                        t.Amount = findTovar.Amount;
                    }
                }
                context.SaveChanges();
            }
            Console.WriteLine("For delete tovar enter his name");
            string deleteName = Console.ReadLine();
            using (var context = new SkladContext())
            {
                var deleted = context.Tovars;
                Tovar deleteTovar;
                foreach (Tovar t in deleted)
                {
                    if (t.Name.Equals(deleteName)==true)
                    {
                        deleteTovar = t;
                        context.Tovars.Remove(deleteTovar);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
