namespace Classroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate111111 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Submissions",
                c => new
                    {
                        SubmissionId = c.Int(nullable: false, identity: true),
                        ClassCode = c.Int(nullable: false),
                        Email = c.String(),
                        DocName = c.String(),
                        DocType = c.String(),
                        Document = c.Binary(),
                        IsMissing = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SubmissionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Submissions");
        }
    }
}
