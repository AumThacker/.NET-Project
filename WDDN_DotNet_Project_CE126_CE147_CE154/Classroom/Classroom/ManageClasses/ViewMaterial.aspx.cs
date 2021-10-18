using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;
using System.IO;

namespace Classroom.ManageClasses
{
    public partial class ViewMaterial : System.Web.UI.Page
    {
        public string title { get; set; }
        public string desc { get; set; }
        public bool is_assignment { get; set; }
        public byte[] file { get; set; }
        public string file_name { get; set; }
        public DateTime? deadline { get; set; }
        public bool is_student { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
            int material_id = int.Parse(Request.QueryString["Id"]);
            using (var model = new ClassroomModel())
            {
                Material material = model.Materials.Where(m => m.MaterialId == material_id).FirstOrDefault<Material>();
                title = material.Title;
                desc = material.Desc;
                is_assignment = material.IsAssignment;
                file = material.Document;
                file_name = material.DocName;
                deadline = material.Deadline;
                string email = Session["current_user"].ToString();
                Student student = model.Students.Where(s => s.Email == email).FirstOrDefault();
                if(student != null)
                {
                    is_student = true;
                }
                else
                {
                    is_student = false;
                }
            }
        }

        protected void view_file_Click(object sender, EventArgs e)
        {
            int material_id = int.Parse(Request.QueryString["Id"]);
            using (var model = new ClassroomModel())
            {
                Material material = model.Materials.Where(m => m.MaterialId == material_id).FirstOrDefault<Material>();
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = material.DocType;
                Response.AddHeader("","attachment;filename=" + material.DocName);
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(material.Document);
                Response.End();
            }
        }

        protected void download_file_Click(object sender, EventArgs e)
        {
            int material_id = int.Parse(Request.QueryString["Id"]);
            using (var model = new ClassroomModel())
            {
                Material material = model.Materials.Where(m => m.MaterialId == material_id).FirstOrDefault<Material>();

                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = material.DocType;
                Response.AddHeader("content-disposition", "attachment;filename=" + material.DocName);
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(material.Document);
                Response.End();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (var model = new ClassroomModel())
            {
                int cls_code = int.Parse(Session["class_code"].ToString());
                string email = Session["current_user"].ToString();
                User user = model.Users.Where(u => u.Email == email).FirstOrDefault<User>();
                Submission submission = new Submission();
                submission.ClassCode = cls_code;
                submission.Email = email;
                submission.SubmissionTime = DateTime.Now;
                string filePath = assignment.PostedFile.FileName;
                string filename = Path.GetFileName(filePath);
                string ext = Path.GetExtension(filename);
                string type = String.Empty;
                if (assignment.HasFile)
                {
                    switch (ext)
                    {
                        case ".pdf":
                            type = "application/pdf";
                            break;

                    }
                    if (type != String.Empty)
                    {
                            System.IO.Stream fs = null;
                            fs = assignment.PostedFile.InputStream;
                            BinaryReader br = new BinaryReader(fs);
                            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                            submission.DocName = filename;
                            submission.DocType = type;
                            submission.Document = bytes;
                    }
                }
                model.Submissions.Add(submission);
                model.SaveChanges();
                Response.Redirect("~/ManageClasses/Stream.aspx");
            }
        }
    }
}