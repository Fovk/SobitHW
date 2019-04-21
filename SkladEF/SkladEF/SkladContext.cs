namespace SkladEF
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SkladContext : DbContext
    {
        // Контекст настроен для использования строки подключения "SkladContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SkladEF.SkladContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "SkladContext" 
        // в файле конфигурации приложения.
        public SkladContext()
            : base("name=SkladContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Tovar> Tovars { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}