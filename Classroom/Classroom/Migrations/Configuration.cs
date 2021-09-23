namespace Classroom.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Classroom.Models.ClassroomModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Classroom.Models.ClassroomModel";
        }

        protected override void Seed(Classroom.Models.ClassroomModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
