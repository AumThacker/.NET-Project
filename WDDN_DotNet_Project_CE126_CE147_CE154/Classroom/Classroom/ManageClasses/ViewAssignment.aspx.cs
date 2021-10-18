using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom.ManageClasses
{
    public partial class ViewAssignment : System.Web.UI.Page
    {
        public string email { get; set; }
        public string name { get; set; }
        public string file_name { get; set; }
        public DateTime? submission_time { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
            int submission_id = int.Parse(Request.QueryString["Id"]);
            using (var model = new ClassroomModel())
            {
                Submission submission = model.Submissions.Where(s => s.SubmissionId == submission_id).FirstOrDefault();
                User user = model.Users.Where(u => u.Email == submission.Email).FirstOrDefault();
                email = user.Email;
                name = user.FName + " " + user.LName;
                file_name = submission.DocName;
                submission_time = submission.SubmissionTime;
            }
        }

        protected void view_file_Click(object sender, EventArgs e)
        {
            int submission_id = int.Parse(Request.QueryString["Id"]);
            using (var model = new ClassroomModel())
            {
                Submission submission = model.Submissions.Where(s => s.SubmissionId == submission_id).FirstOrDefault();
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = submission.DocType;
                Response.AddHeader("", "attachment;filename=" + submission.DocName);
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(submission.Document);
                Response.End();
            }
        }

        protected void download_file_Click(object sender, EventArgs e)
        {
            int submission_id = int.Parse(Request.QueryString["Id"]);
            using (var model = new ClassroomModel())
            {
                Submission submission = model.Submissions.Where(s => s.SubmissionId == submission_id).FirstOrDefault();

                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = submission.DocType;
                Response.AddHeader("content-disposition", "attachment;filename=" + submission.DocName);
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(submission.Document);
                Response.End();
            }
        }
    }
}