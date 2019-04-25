namespace JdHw
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RailWayContext : DbContext
    {
        // Контекст настроен для использования строки подключения "RailWayContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ConsoleApp7.RailWayContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "RailWayContext" 
        // в файле конфигурации приложения.
        public RailWayContext()
            : base("name=RailWayContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<RailWayContext, Migrations.Configuration>());
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Tiket> Tikets { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}