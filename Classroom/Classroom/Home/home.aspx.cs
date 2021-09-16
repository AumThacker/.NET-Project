using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom
{
    public class Classes
    {
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
    }
    public partial class home : System.Web.UI.Page
    {
        public int len { get; set; }
        public Classes[] classes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
            using (var model = new ClassroomModel())
            {
                string email = Session["current_user"].ToString();
                var teachers = model.Teachers.Where(u => u.Email == email).ToList<Teacher>();
                var students = model.Students.Where(u => u.Email == email).ToList<Student>();
                int array_len = teachers.Count();
                array_len += students.Count();
                classes = new Classes[array_len];
                len = 0;
                if(teachers != null)
                {
                    foreach(var t in teachers)
                    {
                        var cls = model.Classes.Where(c => c.ClassCode == t.ClassCode).FirstOrDefault<Class>();
                        classes[len] = new Classes();
                        classes[len].ClassName = cls.ClassName;
                        classes[len].SubjectName = cls.SubName;
                        len++;
                    }
                }
                if (students != null)
                {
                    foreach (var s in students)
                    {
                        var cls = model.Classes.Where(c => c.ClassCode == s.ClassCode).FirstOrDefault<Class>();
                        classes[len] = new Classes();
                        classes[len].ClassName = cls.ClassName;
                        classes[len].SubjectName = cls.SubName;
                        len++;
                    }
                }
            }
        }
    }
}