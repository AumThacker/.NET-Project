namespace Classroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate111 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "UploadTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Materials", "Deadline", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "Deadline");
            DropColumn("dbo.Materials", "UploadTime");
        }
    }
}
