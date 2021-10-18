namespace Classroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "Title");
        }
    }
}
