using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DbUp;
using System.Reflection;

namespace NewsDbUpHW
{
    class Program
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DbUpConnection"].ConnectionString;
        static void Main(string[] args)
        {
            CheckMigration();
            var user = new User
            {
                Login = "admin",
                Password = "qwerty"
            };

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute("insert into Users values(@Id, @Login, @Password);", user);
            }
            Console.ReadLine();
        }
        private static void CheckMigration()
        {
            EnsureDatabase.For.SqlDatabase(_connectionString);

            var upgrader =
        DeployChanges.To
            .SqlDatabase(_connectionString)
            .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
            .LogToConsole()
            .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful) throw new Exception("Ошибка Соединения");
        }
    }
}
