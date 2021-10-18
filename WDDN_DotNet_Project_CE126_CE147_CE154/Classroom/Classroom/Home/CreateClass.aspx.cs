using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom
{
    public partial class CreateClass : System.Web.UI.Page
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
                Random rnd = new Random();
                do
                {
                    int cls_code = rnd.Next(100000, 999999);
                    var cls_code_exist = model.Classes.Where(c => c.ClassCode == cls_code).FirstOrDefault<Class>();
                    if (cls_code_exist == null)
                    {
                        var cls = new Class();
                        cls.ClassCode = cls_code;
                        cls.ClassName = class_name.Text;
                        cls.SubName = subject_name.Text;
                        model.Classes.Add(cls);
                        model.SaveChanges();
                        var teacher = new Teacher();
                        string email = Session["current_user"].ToString();
                        var user = model.Users.Where(u => u.Email == email).FirstOrDefault<User>();
                        if (user != null)
                        {
                            teacher.ClassCode = cls_code;
                            teacher.Email = email;
                            teacher.FName = user.FName;
                            teacher.LName = user.LName;
                            model.Teachers.Add(teacher);
                            model.SaveChanges();
                        }
                        break;
                    }
                } while (true);
                Response.Redirect("../Home/home.aspx");
            }
        }
    }
}