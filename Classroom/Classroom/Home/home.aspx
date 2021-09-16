<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Classroom.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #classes{
            height: 100px;
            width: 1000px;
            border: 1px solid black;
        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        
        <asp:Button ID="create_class" runat="server"  PostBackUrl="~/Home/CreateClass.aspx" Text="Create Class" />
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="join_class" runat="server" PostBackUrl="~/Home/JoinClass.aspx" Text="Join Class" />
        <br />
        <br />
        
        <% for (int c = 0; c < len; c++)
            {    
            %>
                <div id="classes">
                    <a href="CreateClass.aspx"><% =classes[c].ClassName %></a>
                </div>
                <br />
            <%
            }
        %>
        <br />
    </form>

</body>
</html>
