﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classroom.Models;

namespace Classroom.ManageClasses
{
    public partial class Stream : System.Web.UI.Page
    {
        public List<string> title_list { get; set; }
        public List<int> material_id_list { get; set; }
        public List<bool> is_assignment_list { get; set; }
        public string teacher_name { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("../Accounts/Login.aspx");
            }
            if (Request.QueryString["class_code"] != null)
            {
                Session["class_code"] = Request.QueryString["class_code"];
            }
            using (var model = new ClassroomModel())
            {
                int cls_code = int.Parse(Session["class_code"].ToString());
                string email = Session["current_user"].ToString();
                Teacher teacher = model.Teachers.Where(t => t.ClassCode == cls_code && t.Email == email).FirstOrDefault<Teacher>();
                if (teacher != null)
                {
                    teacher_name = teacher.FName + " " + teacher.LName;
                    Session["isTeacher"] = true;
                    Session["isStudent"] = false;
                }
                else
                {
                    Session["isTeacher"] = false;
                    Session["isStudent"] = true;
                }
            }
            using(var model = new ClassroomModel())
            {
                title_list = new List<string>();
                material_id_list = new List<int>();
                is_assignment_list = new List<bool>();
                int cls_code = int.Parse(Session["class_code"].ToString());
                var materials = model.Materials.Where(m => m.ClassCode == cls_code).ToList<Material>();
                foreach (Material material in materials)
                {
                    material_id_list.Add(material.MaterialId);
                    title_list.Add(material.Title);
                    is_assignment_list.Add(material.IsAssignment);
                }
            }
        }
    }
}