namespace Classroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        ClassCode = c.Int(nullable: false),
                        Desc = c.String(),
                        DocName = c.String(),
                        DocType = c.String(),
                        Document = c.Binary(),
                        IsAssignment = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Materials");
        }
    }
}
