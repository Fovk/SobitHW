using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsDbUpHW
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public void AddNews()
        {
            News news = new News();
            Console.WriteLine("Enter Title of news");
            news.Title = Console.ReadLine();
            Console.WriteLine("Enter text(description) of news");
            news.Description = Console.ReadLine();
            news.User = this;
            news.UserLogin = this.Login;
        }
        public void AddComment(News news)
        {
            Comment comment = new Comment();
            Console.WriteLine("Enter comment");
            comment.Content = Console.ReadLine();
            comment.User = this;
            comment.UserLogin = this.Login;
            comment.NewsId = news.Id;        }
    }
}
