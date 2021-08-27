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

namespace Classroom
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Classroom_dbEntities1 db = new Classroom_dbEntities1();
            User user = new User();
            user.Email = email.Text;
            user.Password = password.Text;
            user.FirstName = fname.Text;
            user.LastName = lname.Text;
            db.Users.Add(user);
            db.SaveChanges();
            Response.Redirect("home.aspx");
        }
    }
}