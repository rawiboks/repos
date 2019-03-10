namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TaskAssignSchedules", "TaskAssign_Id", "dbo.TaskAssigns");
            DropIndex("dbo.TaskAssignSchedules", new[] { "TaskAssign_Id" });
            AlterColumn("dbo.TaskAssignSchedules", "TaskAssign_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TaskAssignSchedules", "TaskAssign_Id");
            AddForeignKey("dbo.TaskAssignSchedules", "TaskAssign_Id", "dbo.TaskAssigns", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskAssignSchedules", "TaskAssign_Id", "dbo.TaskAssigns");
            DropIndex("dbo.TaskAssignSchedules", new[] { "TaskAssign_Id" });
            AlterColumn("dbo.TaskAssignSchedules", "TaskAssign_Id", c => c.Int());
            CreateIndex("dbo.TaskAssignSchedules", "TaskAssign_Id");
            AddForeignKey("dbo.TaskAssignSchedules", "TaskAssign_Id", "dbo.TaskAssigns", "Id");
        }
    }
}
