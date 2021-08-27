<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Classroom.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login<br />
            <br />
            Email :
            <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="email_required" runat="server" ControlToValidate="email" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Password :
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="password_required" runat="server" ControlToValidate="password" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Login" />
            <br />
            <br />
            <asp:Label ID="msg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
