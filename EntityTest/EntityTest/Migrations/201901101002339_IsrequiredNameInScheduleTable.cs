namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsrequiredNameInScheduleTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "Name", c => c.String());
        }
    }
}
