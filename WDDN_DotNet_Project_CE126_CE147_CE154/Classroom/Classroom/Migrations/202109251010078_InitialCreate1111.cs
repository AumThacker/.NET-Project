namespace Classroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1111 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Materials", "UploadTime", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Materials", "Deadline", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materials", "Deadline", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Materials", "UploadTime", c => c.DateTime(nullable: false));
        }
    }
}
