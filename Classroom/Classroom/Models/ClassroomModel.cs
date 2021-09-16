using System;
using System.Data.Entity;
using System.Linq;

namespace Classroom.Models
{
    public class ClassroomModel : DbContext
    {
        // Your context has been configured to use a 'ClassroomModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Classroom.Models.ClassroomModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ClassroomModel' 
        // connection string in the application configuration file.
        public ClassroomModel()
            : base("name=ClassroomModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}