<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="People.aspx.cs" Inherits="Classroom.ManageClasses.People" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        h2{
            color:royalblue;
        }
    </style>
</head>
<body>
    <% if (Convert.ToBoolean(Session["isTeacher"]))
            {%>
                <!-- #include file="../Shared/Teacher-nav.aspx" -->
        <%
            }
            else
            {%>
                <!-- #include file="../Shared/Student-nav.aspx" -->
        <%} %>
    <br />
    <h2>Teachers</h2>
    <%
        foreach (string teacher in teachers_list)
        {
            %>
    <hr />
            <p class="fs-5">
                <%=teacher%>
            </p>
    
            <%
        }
        %>
    <br />
    <h2>Students</h2>
        <%
        foreach (string student in students_list)
        {
            %>
    <hr />
            <p class="fs-5">
                <%=student%>
            </p>
            <%
        }
    %>
</body>
</html>
