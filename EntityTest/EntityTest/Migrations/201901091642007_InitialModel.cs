namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Schedule_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.Schedule_Id)
                .Index(t => t.Schedule_Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Day0 = c.String(),
                        Day1 = c.String(),
                        Day2 = c.String(),
                        Day3 = c.String(),
                        Day4 = c.String(),
                        Day5 = c.String(),
                        Day6 = c.String(),
                        TimeStart = c.Time(nullable: false, precision: 7),
                        TimeFinish = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskAssigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.Time(nullable: false, precision: 7),
                        FinishTime = c.Time(nullable: false, precision: 7),
                        Day0 = c.Boolean(nullable: false),
                        Day1 = c.Boolean(nullable: false),
                        Day2 = c.Boolean(nullable: false),
                        Day3 = c.Boolean(nullable: false),
                        Day4 = c.Boolean(nullable: false),
                        Day5 = c.Boolean(nullable: false),
                        Day6 = c.Boolean(nullable: false),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Task_Id);
            
            CreateTable(
                "dbo.TaskAssignManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Manager_Id = c.Int(),
                        TaskAssign_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Managers", t => t.Manager_Id)
                .ForeignKey("dbo.TaskAssigns", t => t.TaskAssign_Id)
                .Index(t => t.Manager_Id)
                .Index(t => t.TaskAssign_Id);
            
            CreateTable(
                "dbo.TaskAssignSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Schedule_Id = c.Int(),
                        TaskAssign_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.Schedule_Id)
                .ForeignKey("dbo.TaskAssigns", t => t.TaskAssign_Id)
                .Index(t => t.Schedule_Id)
                .Index(t => t.TaskAssign_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskAssignSchedules", "TaskAssign_Id", "dbo.TaskAssigns");
            DropForeignKey("dbo.TaskAssignSchedules", "Schedule_Id", "dbo.Schedules");
            DropForeignKey("dbo.TaskAssignManagers", "TaskAssign_Id", "dbo.TaskAssigns");
            DropForeignKey("dbo.TaskAssignManagers", "Manager_Id", "dbo.Managers");
            DropForeignKey("dbo.TaskAssigns", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.Managers", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.TaskAssignSchedules", new[] { "TaskAssign_Id" });
            DropIndex("dbo.TaskAssignSchedules", new[] { "Schedule_Id" });
            DropIndex("dbo.TaskAssignManagers", new[] { "TaskAssign_Id" });
            DropIndex("dbo.TaskAssignManagers", new[] { "Manager_Id" });
            DropIndex("dbo.TaskAssigns", new[] { "Task_Id" });
            DropIndex("dbo.Managers", new[] { "Schedule_Id" });
            DropTable("dbo.TaskAssignSchedules");
            DropTable("dbo.TaskAssignManagers");
            DropTable("dbo.TaskAssigns");
            DropTable("dbo.Tasks");
            DropTable("dbo.Schedules");
            DropTable("dbo.Managers");
        }
    }
}
