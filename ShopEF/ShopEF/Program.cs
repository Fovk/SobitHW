using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //для инициализации таблиц
            //using (var context = new ShopContext())
            //{
            //    context.Products.Add(
            //        new Product
            //        {
            //            Name = "water",
            //            Price = 10
            //        });
            //    context.Products.Add(
            //        new Product
            //        {
            //            Name = "eggs",
            //            Price = 15
            //        });
            //    context.SaveChanges();
            //}
            //User user = new User
            //{
            //    Login = "admin",
            //    Password = "123",
            //};
            //user.Basket = new Basket
            //{
            //    UserId = user.Id
            //};
            //using (ShopContext context = new ShopContext())
            //{
            //    context.Users.Add(user);
            //    context.SaveChanges();
            //}
            Menu menu = new Menu();
            menu.StartMenu();
        }
    }
}
