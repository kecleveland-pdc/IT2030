namespace EventFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventFinderDB_Migration5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventFinderEvents", "AmountOfTickets", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EventFinderEvents", "AmountOfTickets");
        }
    }
}
