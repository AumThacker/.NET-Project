using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Classroom.Models;

namespace Classroom
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            using (var model = new ClassroomModel())
            {
                var check_email = model.Users.Where(u => u.Email == email.Text).FirstOrDefault<User>();
                if(check_email == null)
                {
                    var user = new User();
                    user.Email = email.Text;
                    user.Password = password.Text;
                    user.FName = fname.Text;
                    user.LName = lname.Text;
                    model.Users.Add(user);
                    model.SaveChanges();
                    Session["current_user"] = email.Text;
                    Response.Redirect("../Home/home.aspx");
                }
                else
                {
                    email_exist.Text = "Account already exist.";
                }
            }
        }
    }
}