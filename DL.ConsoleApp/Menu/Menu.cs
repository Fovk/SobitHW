using DL.DataAcess;
using DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class MenuClass
    {
        public void StartMenu()
        {
            Console.WriteLine("enter 1 for add receiver ");
            Console.WriteLine("enter 2 for delete receiver ");
            Console.WriteLine("enter 3 for update receiver ");
            Console.WriteLine("enter 4 for add mail ");
            Console.WriteLine("enter 5 for delete mail ");
            Console.WriteLine("enter 6 for update mail ");
            string _userMenuType=Console.ReadLine();
            int _menuType;
            int.TryParse(_userMenuType, out _menuType);
            switch (_menuType)
            {
                case 1: AddResiever(); break;
                case 2: DeleteResiever(); break;
                case 3: UpdateResiever(); break;
                case 4: AddMail(); break;
                case 5: DeleteMail(); break;
                case 6: UpdateMail(); break;
            }
        }
        public void AddResiever()
        {
            Receiver receiver = new Receiver();
            Console.WriteLine("Enter Fullname");
            receiver.FullName = Console.ReadLine();
            Console.WriteLine("Enter Adress");
            receiver.Address = Console.ReadLine();
            using (var repository = new ReceiversRepository())
            {
                repository.Add(receiver);
            };
        }
        public void DeleteResiever()
        {
            Console.WriteLine("Enter Id");
            Guid guid;
            Guid.TryParse(Console.ReadLine(),out guid);
            using (var repository = new ReceiversRepository())
            {
                repository.Delete(guid);
            };
        }
        public void UpdateResiever()
        {
            Receiver receiver = new Receiver();
            Console.WriteLine("Enter Id");
            Guid guid;
            Guid.TryParse(Console.ReadLine(), out guid);
            receiver.Id = guid;
            Console.WriteLine("Enter Fullname");
            receiver.FullName = Console.ReadLine();
            Console.WriteLine("Enter Adress");
            receiver.Address = Console.ReadLine();
            using (var repository = new ReceiversRepository())
            {
                repository.Update(receiver);
            };
        }
        public void AddMail()
        {
            Mail mail = new Mail();
            Console.WriteLine("Enter Theme");
            mail.Theme = Console.ReadLine();
            Console.WriteLine("Enter Text");
            mail.Text = Console.ReadLine();
            Console.WriteLine("Enter Receiver Id");
            Guid guid;
            Guid.TryParse(Console.ReadLine(), out guid);
            mail.ReceiverId = guid;
            using (var repository = new MailRepository())
            {
                repository.Add(mail);
            };
        }
        public void DeleteMail()
        {
            Console.WriteLine("Enter Id");
            Guid guid;
            Guid.TryParse(Console.ReadLine(), out guid);
            using (var repository = new MailRepository())
            {
                repository.Delete(guid);
            };
        }
        public void UpdateMail()
        {
            Console.WriteLine("Enter Id");
            Guid guid;
            Guid.TryParse(Console.ReadLine(), out guid);
            Mail mail = new Mail();
            Console.WriteLine("Enter Theme");
            mail.Theme = Console.ReadLine();
            Console.WriteLine("Enter Text");
            mail.Text = Console.ReadLine();
            Console.WriteLine("Enter Receiver Id");
            Guid receiverGuid;
            Guid.TryParse(Console.ReadLine(), out receiverGuid);
            mail.ReceiverId = receiverGuid;
            using (var repository = new MailRepository())
            {
                repository.Update(mail);
            };
        }
    }
}
