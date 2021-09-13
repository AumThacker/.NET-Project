<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Classroom.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">
        
        <asp:Button ID="create_class" runat="server"  PostBackUrl="~/CreateClass.aspx" Text="Create Class" />
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="join_class" runat="server" PostBackUrl="~/JoinClass.aspx" Text="Join Class" />
        
    </form>

</body>
</html>
