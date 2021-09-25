using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

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
    }
}