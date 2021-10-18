<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSubmission.aspx.cs" Inherits="Classroom.ManageClasses.ViewSubmission" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Submission</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        h2 {
            color: royalblue;
        }
        span::after {
            content: '\007C';
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
        <div style="margin-left: 5px;">
            <h2>Submitted</h2>
            <hr />
            <h5><% =turned_in_students %> Turned in &nbsp;&nbsp;&nbsp;<span></span>&nbsp;&nbsp;&nbsp; <% =assigned_students %> Assigned</h5>
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">First Name</th>
                        <th scope="col">Last Name</th>
                        <th scope="col">Email</th>
                        <th scope="col">Assignment</th>
                    </tr>
                </thead>
                <tbody>
                    <%for (int i = 0; i < SubmittedStudents.Count; i++)
                        { %>
                    <tr>
                        <td><% =i+1 %></td>
                        <td><% =SubmittedStudents[i].FName %></td>
                        <td><% =SubmittedStudents[i].LName %></td>
                        <td><% =Submitted[i].Email %></td>
                        <td>
                            <a href="../ManageClasses/ViewAssignment.aspx/?Id=<%=Submitted[i].SubmissionId %>" style="text-decoration:none;">View</a>
                        </td>
                    </tr>
                    <%} %>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
