﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom.ManageClasses
{
    public partial class AddMaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
        }

        protected void upload_Click(object sender, EventArgs e)
        {
            string filePath = file.PostedFile.FileName;
            string filename = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename);
            string type = String.Empty;
            if (file.HasFile)
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
                    fs = file.PostedFile.InputStream;
                    BinaryReader br = new BinaryReader(fs);
                    Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    using(var model = new ClassroomModel())
                    {
                        Material material = new Material();
                        material.ClassCode = int.Parse(Session["class_code"].ToString());
                        material.Title = title.Text;
                        material.Desc = desc.Text;
                        material.DocName = filename;
                        material.DocType = type;
                        material.Document = bytes;
                        if (is_assignment.Checked)
                            material.IsAssignment = true;
                        else
                            material.IsAssignment = false;
                        model.Materials.Add(material);
                        model.SaveChanges();
                        Response.Redirect("~/Stream.aspx");
                    }
                }
            }
        }
    }
}