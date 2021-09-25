<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMaterial.aspx.cs" Inherits="Classroom.ManageClasses.ViewMaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        h2 {
            color: royalblue;
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
        <div>
            <h2 style="margin-left: 5px;"><%=title %></h2>
            <div style="float: right;">
                <%if (is_assignment)
                    { %>
                <%if (deadline != null)
                    {%><h6 style="margin-right: 5px">Due  <%=deadline %></h6>
                <%}
                    else
                    { %><h6 style="margin-right: 5px">No due date</h6>
                <%}
                    } %>
            </div>
        </div>
        <hr style="margin-top: 35px" />
        <div style="margin-left: 5px">
            <p style="font-size: large"><%=desc %></p>
            <h4>Attachment</h4>

            <p style="margin-bottom: 6px"><%=file_name %></p>

            <asp:Button ID="view_file" runat="server" Text="View File" class="btn btn-primary" OnClick="view_file_Click" />
            <asp:Button ID="download_file" runat="server" Text="Download File" class="btn btn-primary" OnClick="download_file_Click" />
            <br />
            <br />
            <%if (is_assignment)
                { %>
            <h4>Submit Assignment</h4>
            <asp:FileUpload runat="server" ID="assignment" class="form-control" Style="margin-top: 10px; margin-bottom: 8px" />
            <asp:Button Text="Submit" runat="server" class="btn btn-primary" />
            <%} %>
        </div>

    </form>
</body>
</html>
