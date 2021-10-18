<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssignment.aspx.cs" Inherits="Classroom.ManageClasses.ViewAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Assignment</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        h2 {
            color: royalblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
        </div>
        <div style="margin-left: 5px;">
            <br />
            <h2>View Submission</h2>
            <hr />
            <h5>Name</h5>
            <p><% =name %></p>
            <h5>Email</h5>
            <p><% =email %></p>
            <h5>Attachment</h5>
            <p><% =file_name %></p>
            <asp:Button ID="view_file" Text="View Assignment" runat="server" OnClick="view_file_Click" class="btn btn-primary" />
            <asp:Button ID="download_file" Text="Download Assignment" runat="server" class="btn btn-primary" OnClick="download_file_Click" />
            <h6 style="margin-top:7px;">Submission time</h6>
            <p><% =submission_time %></p>
        </div>
    </form>
</body>
</html>
