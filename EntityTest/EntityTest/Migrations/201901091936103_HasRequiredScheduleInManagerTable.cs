namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HasRequiredScheduleInManagerTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Managers", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Managers", new[] { "Schedule_Id" });
            AlterColumn("dbo.Managers", "Schedule_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Managers", "Schedule_Id");
            AddForeignKey("dbo.Managers", "Schedule_Id", "dbo.Schedules", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Managers", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Managers", new[] { "Schedule_Id" });
            AlterColumn("dbo.Managers", "Schedule_Id", c => c.Int());
            CreateIndex("dbo.Managers", "Schedule_Id");
            AddForeignKey("dbo.Managers", "Schedule_Id", "dbo.Schedules", "Id");
        }
    }
}
