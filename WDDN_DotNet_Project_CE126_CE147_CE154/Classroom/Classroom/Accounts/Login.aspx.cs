using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["current_user"] = null;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            using (var model = new ClassroomModel())
            {
                var user = model.Users.Where(u => u.Email == email.Text).FirstOrDefault<User>();
                if(user != null && user.Password == password.Text)
                {
                    Session["current_user"] = user.Email;
                    Response.Redirect("../Home/home.aspx");
                }
                else
                {
                    msg.Text = "Email or Password is incorrect.";
                }
            }
        }
    }
}