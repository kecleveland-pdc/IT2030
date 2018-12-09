namespace EventFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventFinderDB_Migration4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventFinderCarts",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        CartID = c.String(),
                        EventFinderEventID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.EventFinderEvents", t => t.EventFinderEventID, cascadeDelete: true)
                .Index(t => t.EventFinderEventID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventFinderCarts", "EventFinderEventID", "dbo.EventFinderEvents");
            DropIndex("dbo.EventFinderCarts", new[] { "EventFinderEventID" });
            DropTable("dbo.EventFinderCarts");
        }
    }
}
