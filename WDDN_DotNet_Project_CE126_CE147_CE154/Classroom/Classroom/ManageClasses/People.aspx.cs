using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom.ManageClasses
{
    public partial class People : System.Web.UI.Page
    {
        public string[] teachers_list { get; set; }
        public string[] students_list { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
            using (var model = new ClassroomModel())
            {
                int cls_code = int.Parse(Session["class_code"].ToString());
                var teachers = model.Teachers.Where(u => u.ClassCode == cls_code).ToList<Teacher>();
                var students = model.Students.Where(u => u.ClassCode == cls_code).ToList<Student>();
                int teacher_count = teachers.Count();
                int student_count = students.Count();
                teachers_list = new string[teacher_count];
                students_list = new string[student_count];
                int i = 0, j=0;
                if (teachers != null)
                {
                    foreach (var t in teachers)
                    {
                        teachers_list[i] = t.FName + " " + t.LName;
                        i++;
                    }
                }
                if (students != null)
                {
                    foreach (var s in students)
                    {
                        students_list[j] = s.FName + " " + s.LName;
                        j++;
                    }
                }
            }

        }
    }
}