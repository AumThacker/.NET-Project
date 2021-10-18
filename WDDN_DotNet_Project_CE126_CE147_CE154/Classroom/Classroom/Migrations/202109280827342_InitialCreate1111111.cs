namespace Classroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1111111 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Submissions", "SubmissionTime", c => c.DateTime());
            DropColumn("dbo.Submissions", "IsMissing");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Submissions", "IsMissing", c => c.Boolean(nullable: false));
            DropColumn("dbo.Submissions", "SubmissionTime");
        }
    }
}
