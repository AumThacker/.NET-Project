using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom
{
    public partial class JoinClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            using (var model = new ClassroomModel())
            {
                var cls_code = int.Parse(class_code.Text);
                var cls = model.Classes.Where(c => c.ClassCode == cls_code).FirstOrDefault<Class>();
                if (cls != null)
                {
                    var stud = new Student();
                    string email = Session["current_user"].ToString();
                    var user = model.Users.Where(u => u.Email == email).FirstOrDefault<User>();
                    if (user != null)
                    {
                        stud.ClassCode = cls.ClassCode;
                        stud.Email = email;
                        stud.FName = user.FName;
                        stud.LName = user.LName;
                        model.Students.Add(stud);
                        model.SaveChanges();
                    }
                    Response.Redirect("../Home/home.aspx");
                }
                else
                {
                    err.Text = "Please enter valid Class Code.";
                }
            }
        }
    }
}