namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1014_Update4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Credits", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Credits", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
