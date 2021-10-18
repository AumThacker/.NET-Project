using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom.ManageClasses
{
    public partial class ViewSubmission : System.Web.UI.Page
    {
        public List<Submission> Submitted { get; set; }
        public List<Student> SubmittedStudents { get; set; }
        public int assigned_students { get; set; }
        public int turned_in_students { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
            SubmittedStudents = new List<Student>();
            Submitted = new List<Submission>();
            List<string> email_list = new List<string>();
            using (var model = new ClassroomModel())
            {
                int cls_code = int.Parse(Session["class_code"].ToString());
                var submission = model.Submissions.Where(s => s.ClassCode == cls_code).ToList<Submission>();
                foreach (var s in submission)
                {
                    Student student = model.Students.Where(u => u.Email == s.Email).FirstOrDefault<Student>();
                    SubmittedStudents.Add(student);
                    Submitted.Add(s);
                    if (!email_list.Contains(student.Email))
                    {
                        email_list.Add(student.Email);
                    }
                }
                assigned_students = model.Students.Where(s => s.ClassCode == cls_code).Count();
                turned_in_students = email_list.Count();
            }
        }
    }
}