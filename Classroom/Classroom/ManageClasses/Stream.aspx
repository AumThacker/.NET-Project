<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stream.aspx.cs" Inherits="Classroom.ManageClasses.Stream" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .panel{
            width:auto;
            height:auto;
            border: 1px solid #e3f2fd;
        }
        .panel-heading{
            background-color:#c9e9ff;
            padding-bottom:0.1%;
            padding-top:1%;
            padding-left:1%;
        }
        .panel-body{
            padding:1%;
        }
    </style>
</head>
<body>
    <div>
        <% if (Convert.ToBoolean(Session["isTeacher"]) && !Convert.ToBoolean(Session["isStudent"]))
            {%>
                <!-- #include file="../Shared/Teacher-nav.aspx" -->
        <%
            }
            else if (!Convert.ToBoolean(Session["isTeacher"]) && Convert.ToBoolean(Session["isStudent"]))
            {%>
                <!-- #include file="../Shared/Student-nav.aspx" -->
        <%} %>
        <br />
    </div>
    <% for (int m = 0; m < material_id_list.Count; m++)
           {
           %>
                
           <a href="People.aspx" style="text-decoration: none; color: black">
               <div class="panel">
                   <div class="panel-heading">
                       <% if (is_assignment_list[m])
                           {
                               %>
                               <p><%=teacher_name %> posted a new assignment</p>
                               <%

                           }
                            else
                            {
                               %>
                               <p><%=teacher_name %> posted a new material</p>
                               <%
                            }
                        %>
                   </div>
                   <div class="panel-body">
                       <%=title_list[m] %>
                   </div>
               </div>
           </a>
           <br />
           <%
           }
        %>
</body>
</html>
