using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEF
{
    public class Menu
    {
        public void StartMenu()
        {
            Console.WriteLine("enter 1 for register ");
            Console.WriteLine("enter 2 for autorizate ");
            string _userMenuType = Console.ReadLine();
            int _menuType;
            int.TryParse(_userMenuType, out _menuType);
            switch (_menuType)
            {
                case 1: Register(); break;
                case 2: Autorization(); break;
            }
        }
        public void Register()
        {
            User user = new User();
            Console.WriteLine("Enter Login");
            Console.WriteLine("Your Login must be unique");
            string _login= Console.ReadLine();
            List<User> presentUsers;
            using (var context =new ShopContext())
            {
                presentUsers = context.Users.Where(c => c.Login.Equals(_login)).ToList();
            }
            if (presentUsers.Count == 0)
            {
                user.Login = _login;
                Console.WriteLine("Enter Password");
                string _password = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(_password))
                {
                    user.Password = _password;
                    user.Basket.UserId = user.Id;
                    using (var context = new ShopContext())
                    {
                        context.Users.Add(user);
                        AddProductToBasket(user);
                        context.SaveChanges();
                    }
                }
                else Console.WriteLine("Password was Empty");
            }

            else Console.WriteLine("Your Login is already used");
        }

        public void Autorization()
        {
            User user;
            Console.WriteLine("Enter your Login");
            string _login = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string _password = Console.ReadLine();
            List<User> registeredUsers;
            using (var context = new ShopContext())
            {
                registeredUsers = context.Users.Where(c => c.Login.Equals(_login)&&c.Password.Equals(_password)).ToList();
            }
            if (registeredUsers.Count >= 0)
            {
                user=registeredUsers.First();
                ShowBasket(user);
                Console.WriteLine("Enter anyword if you want to add products to basket");
                Console.WriteLine("Live it empty to end adding");
                string _userWill = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(_userWill)) AddProductToBasket(user);
            }
            else Console.WriteLine("User dont exist or Login/Password wrong");
        }
        public void ShowBasket(User user)
        {
            using (var context = new ShopContext())
            {
                user.Basket=context.Baskets.Where(b=>b.UserId.Equals(user.Id)).First();
            }
            foreach (Product p in user.Basket.Products)
            {
                Console.WriteLine($"Product Name {p.Name}, Price {p.Price} ");
            }
        }
        public void AddProductToBasket(User user)
        {
            List<Product> products;
            using(var context=new ShopContext())
            {
                products= context.Products.ToList();
            }
            foreach(Product p in products)
            {
                Console.WriteLine($"Product Name {p.Name}, Price {p.Price} ");
            }
            Console.WriteLine("Enter product Name to add it to busket");
            string _productName = Console.ReadLine();
            user.Basket.Products.AddRange(products.Where(p => p.Name.Contains(_productName)));
            user.Basket.UserId = user.Id;
            using (var context = new ShopContext())
            {
                context.Baskets.Add(user.Basket);
                context.SaveChanges();
            }
        }
    }
}
