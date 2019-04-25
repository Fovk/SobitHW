using DL.DataAcess;
using DL.Models;
using Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
            MenuClass menu = new MenuClass();
            var receiver = new Receiver
            {
                FullName = "Пётр Ильин",
                Address = "Астана, улица Фурманова"
            };
            var mail = new Mail
            {
                CreationDate = DateTime.Now,
                Text = "Hello World",
                Theme = "Hello",
                ReceiverId = receiver.Id
                };
            using (var repository = new ReceiversRepository())
			{
				
				repository.Add(receiver);

				var receivers = repository.GetAll();
			};
            using (var repository =new MailRepository())
            {
                repository.Add(mail);
            }
            menu.StartMenu();
		}
	}
}
