using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Classroom
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Classroom_dbEntities1 db = new Classroom_dbEntities1();
            User user = new User();
            user = db.Users.Where(u => u.Email == email.Text).FirstOrDefault<User>();
            if(user != null && user.Password == password.Text)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                msg.Text = "Invalid credentials.";
            }
        }
    }
}