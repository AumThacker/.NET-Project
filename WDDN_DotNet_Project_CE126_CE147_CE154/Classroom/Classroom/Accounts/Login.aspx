<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Classroom.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        form{
            margin-left: 5px;
        }
        #link{
            text-decoration: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <h2>Classroom</h2>
        <hr />
        <div>
            <div class="mb-3">    
                <asp:Label ID="Label1" runat="server" Text="Email Address" class="form-label"></asp:Label>
                <asp:TextBox ID="email" runat="server" TextMode="Email" class="form-control" Width="315px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ForeColor="Red">Email is required.</asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">              
                <asp:Label ID="Label2" runat="server" Text="Password" class="form-label"></asp:Label>
                <asp:TextBox ID="password" runat="server" TextMode="Password" class="form-control" Width="315px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="password" ForeColor="Red">Password is required.</asp:RequiredFieldValidator> 
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="submit_Click" Text="Login" class="btn btn-primary" />
            <br />
            <br />
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p>New User? <asp:HyperLink ID="link" NavigateUrl="~/Accounts/Registration.aspx" runat="server" Text="Sign Up" /></p>
        </div>
    </form>
</body>
</html>
