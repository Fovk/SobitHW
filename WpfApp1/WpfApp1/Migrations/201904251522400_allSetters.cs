namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allSetters : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "PhoneCod", c => c.String());
            AddColumn("dbo.Cities", "PhoneCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "PhoneCode");
            DropColumn("dbo.Cities", "PhoneCod");
        }
    }
}
