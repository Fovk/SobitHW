namespace MigrationsHW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVisitorIIN : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "IIN", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "IIN", c => c.String());
        }
    }
}
