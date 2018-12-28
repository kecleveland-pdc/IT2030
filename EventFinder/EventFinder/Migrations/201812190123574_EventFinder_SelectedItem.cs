namespace EventFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventFinder_SelectedItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventFinderEvents", "SelectedEvent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EventFinderEvents", "SelectedEvent");
        }
    }
}
