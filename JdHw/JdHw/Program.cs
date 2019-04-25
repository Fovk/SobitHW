using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdHw
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiket tiket = new Tiket();
            tiket.Price = 5000;
            Train train = new Train();
            User user = new User();
            City astana =new City{
                Name="Nur-Sultan"
            };
            City almaty = new City
            {
                Name = "Almaty"
            };
            //using (var context = new RailWayContext())
            //{
            //    context.Cities.Add(astana);
            //    context.Cities.Add(almaty);
            //    context.SaveChanges();
            //}
            Console.WriteLine("You need to set Destination City and Departure City");
            List<City> cities;
            using (var context = new RailWayContext())
            {
                cities = context.Cities.ToList();
            }
            if (cities == null) Console.WriteLine("Cities dont added");
            else
            {
                foreach (var i in cities)
                {
                    Console.WriteLine(i.Name);
                }
            }
            Console.WriteLine("Enter your Destination City");
            string destinationCity = Console.ReadLine();
            Guid existId1 = Guid.Empty;
            foreach (var i in cities)
            {
                if (i.Name.Contains(destinationCity) == true)
                {
                    existId1 = i.Id;
                    tiket.DestinationId = existId1;
                }
            }
            if (existId1 == Guid.Empty) Console.WriteLine("Destination City dosnt exist");
            Console.WriteLine("Enter your Departure City");
            string departureCity = Console.ReadLine();
            Guid existId2 = Guid.Empty;
            foreach (var i in cities)
            {
                if (i.Name.Contains(departureCity) == true)
                {
                    existId2 = i.Id;
                    tiket.DestinationId = existId2;
                }
            }
            if (existId2 == Guid.Empty) Console.WriteLine("Departure City dosnt exist");
            Console.WriteLine("Enter your Full Name");
            user.FullName = Console.ReadLine();
            Console.WriteLine("Choose Vagon number");
            int vagonnumber;
            Vagon vagon = new Vagon();
            int.TryParse(Console.ReadLine(), out vagonnumber);
            vagon = train.Treno[vagonnumber];
            Console.WriteLine("Choose vagon sit");
            int polkatype;
            Polka polka = new Polka();
            int.TryParse(Console.ReadLine(), out polkatype);
            if (polkatype < 4)
            {
                switch (polkatype)
                {
                    case 0: polka = Polka.verhnyualevo; break;
                    case 1: polka = Polka.verhnyuapravo; break;
                    case 2: polka = Polka.nizhnyaalevo; break;
                    case 3: polka = Polka.nizhnyaapravo; break;
                }
            }
            using (var context = new RailWayContext())
            {
                context.Users.Add(user);
                context.Trains.Add(train);
                context.Tikets.Add(tiket);
                context.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
