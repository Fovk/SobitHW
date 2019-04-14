namespace MigrationsHW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FullName = c.String(),
                        IIN = c.String(),
                        DateEnter = c.DateTime(nullable: false),
                        DateExit = c.DateTime(),
                        AimVisit = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
        }
    }
}
