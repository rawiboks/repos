namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsrequiredDay0InSchedulesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "Day0", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "Day0", c => c.String());
        }
    }
}
