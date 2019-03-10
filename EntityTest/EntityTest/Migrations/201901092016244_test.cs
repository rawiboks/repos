namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TaskAssigns", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.TaskAssignSchedules", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.TaskAssigns", new[] { "Task_Id" });
            DropIndex("dbo.TaskAssignSchedules", new[] { "Schedule_Id" });
            AlterColumn("dbo.TaskAssigns", "Task_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.TaskAssignSchedules", "Schedule_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TaskAssigns", "Task_Id");
            CreateIndex("dbo.TaskAssignSchedules", "Schedule_Id");
            AddForeignKey("dbo.TaskAssigns", "Task_Id", "dbo.Tasks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TaskAssignSchedules", "Schedule_Id", "dbo.Schedules", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskAssignSchedules", "Schedule_Id", "dbo.Schedules");
            DropForeignKey("dbo.TaskAssigns", "Task_Id", "dbo.Tasks");
            DropIndex("dbo.TaskAssignSchedules", new[] { "Schedule_Id" });
            DropIndex("dbo.TaskAssigns", new[] { "Task_Id" });
            AlterColumn("dbo.TaskAssignSchedules", "Schedule_Id", c => c.Int());
            AlterColumn("dbo.TaskAssigns", "Task_Id", c => c.Int());
            CreateIndex("dbo.TaskAssignSchedules", "Schedule_Id");
            CreateIndex("dbo.TaskAssigns", "Task_Id");
            AddForeignKey("dbo.TaskAssignSchedules", "Schedule_Id", "dbo.Schedules", "Id");
            AddForeignKey("dbo.TaskAssigns", "Task_Id", "dbo.Tasks", "Id");
        }
    }
}
