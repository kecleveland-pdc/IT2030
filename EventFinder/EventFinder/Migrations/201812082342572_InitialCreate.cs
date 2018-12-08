namespace EventFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventFinderEvents",
                c => new
                    {
                        EventFinderEventID = c.Int(nullable: false, identity: true),
                        EventFinderEventTypeID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        MaxTickets = c.Int(nullable: false),
                        AvailableTickets = c.Int(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        OrganizerEmail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EventFinderEventID)
                .ForeignKey("dbo.EventFinderEventTypes", t => t.EventFinderEventTypeID, cascadeDelete: true)
                .Index(t => t.EventFinderEventTypeID);
            
            CreateTable(
                "dbo.EventFinderEventTypes",
                c => new
                    {
                        EventFinderEventTypeID = c.Int(nullable: false, identity: true),
                        EventType = c.String(),
                    })
                .PrimaryKey(t => t.EventFinderEventTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventFinderEvents", "EventFinderEventTypeID", "dbo.EventFinderEventTypes");
            DropIndex("dbo.EventFinderEvents", new[] { "EventFinderEventTypeID" });
            DropTable("dbo.EventFinderEventTypes");
            DropTable("dbo.EventFinderEvents");
        }
    }
}
