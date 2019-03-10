namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HasRequiredNameManagerTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "Name", c => c.String());
        }
    }
}
