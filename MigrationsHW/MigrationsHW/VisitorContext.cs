namespace MigrationsHW
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VisitorContext : DbContext
    {
        
        public VisitorContext()
            : base("name=VisitorContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<VisitorContext, Migrations.Configuration>());
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}