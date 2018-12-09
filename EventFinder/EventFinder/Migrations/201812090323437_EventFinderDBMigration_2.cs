namespace EventFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventFinderDBMigration_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventFinderEvents", "State", c => c.String(nullable: false, maxLength: 2));
            AddColumn("dbo.EventFinderEvents", "City", c => c.String(nullable: false, maxLength: 35));
            AddColumn("dbo.EventFinderEvents", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.EventFinderEvents", "LastName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.EventFinderEvents", "Address");
            DropColumn("dbo.EventFinderEvents", "OrganizerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventFinderEvents", "OrganizerName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.EventFinderEvents", "Address", c => c.String(nullable: false));
            DropColumn("dbo.EventFinderEvents", "LastName");
            DropColumn("dbo.EventFinderEvents", "FirstName");
            DropColumn("dbo.EventFinderEvents", "City");
            DropColumn("dbo.EventFinderEvents", "State");
        }
    }
}
