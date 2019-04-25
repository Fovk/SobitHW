namespace JdHw.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VagonctorInVsagonArr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tikets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Price = c.Int(nullable: false),
                        DestinationId = c.Guid(nullable: false),
                        DepartureId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        TrainId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trains", t => t.TrainId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.TrainId);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        trainSize = c.Int(nullable: false),
                        TimeDeparture = c.DateTime(nullable: false),
                        TimeArrival = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TiketCities",
                c => new
                    {
                        Tiket_Id = c.Guid(nullable: false),
                        City_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tiket_Id, t.City_Id })
                .ForeignKey("dbo.Tikets", t => t.Tiket_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: true)
                .Index(t => t.Tiket_Id)
                .Index(t => t.City_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tikets", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tikets", "TrainId", "dbo.Trains");
            DropForeignKey("dbo.TiketCities", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.TiketCities", "Tiket_Id", "dbo.Tikets");
            DropIndex("dbo.TiketCities", new[] { "City_Id" });
            DropIndex("dbo.TiketCities", new[] { "Tiket_Id" });
            DropIndex("dbo.Tikets", new[] { "TrainId" });
            DropIndex("dbo.Tikets", new[] { "UserId" });
            DropTable("dbo.TiketCities");
            DropTable("dbo.Users");
            DropTable("dbo.Trains");
            DropTable("dbo.Tikets");
            DropTable("dbo.Cities");
        }
    }
}
