<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Classroom.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        form{
            margin-left: 5px;
        }
        #link{
            text-decoration: none;
        }
    </style>
    <script type="text/javascript">
        function validatePassword(source, arguments) {
            arguments.IsValid = false;
            var password = arguments.Value;
            if (password.length >= 6 && password.length <= 14) {
                let lowercase = false;
                let uppercase = false;
                let numbers = false;
                for (let i in password) {
                    if (password[i] >= 'a' && password[i] <= 'z') {
                        lowercase = true;
                    }
                    else if (password[i] >= 'A' && password[i] <= 'Z') {
                        uppercase = true;
                    }
                    else if (password[i] >= '0' && password[i] <= '9') {
                        numbers = true;
                    }
                    if (lowercase == true && uppercase == true && numbers == true) {
                        arguments.IsValid = true;
                        break;
                    }
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <h2>Registration</h2>
        <hr />
        <div class="auto-style1">
            <div class="mb-3">    
                <asp:Label ID="Label1" runat="server" Text="Email Address" class="form-label"></asp:Label>
                <asp:TextBox ID="email" runat="server" TextMode="Email" class="form-control" Width="315px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="email_required" runat="server" ControlToValidate="email" ForeColor="Red">Email is required.</asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">              
                <asp:Label ID="Label2" runat="server" Text="Password" class="form-label"></asp:Label>
                <asp:TextBox ID="password" runat="server" TextMode="Password" class="form-control" Width="315px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="password_required" runat="server" ControlToValidate="password" ForeColor="Red">Password is required</asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <asp:Label ID="Label3" runat="server" Text="Confirm Password" class="form-label"></asp:Label>
                <asp:TextBox ID="conf_password" runat="server" TextMode="Password"  class="form-control" Width="315px"></asp:TextBox>            
                <asp:RequiredFieldValidator ID="conf_pass_required" runat="server" ControlToValidate="conf_password" ForeColor="Red">Confirm Password is required</asp:RequiredFieldValidator>
            </div>
            <div class ="mb-3">
                <asp:Label ID="Label4" runat="server" Text="First Name" class="form-label"></asp:Label>
                <asp:TextBox ID="fname" runat="server"  class="form-control" Width="315px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="fname_required" runat="server" ControlToValidate="fname" ForeColor="Red">First name is required</asp:RequiredFieldValidator>
            </div>
            <div class ="mb-3">
                <asp:Label ID="Label5" runat="server" Text="Last Name" class="form-label"></asp:Label>
                <asp:TextBox ID="lname" runat="server"  class="form-control" Width="315px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="lname_required" runat="server" ControlToValidate="lname" ForeColor="Red">Last name is required</asp:RequiredFieldValidator>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="submit_Click" Text="Register" class="btn btn-primary" />
            <br />
            <br />
            <p>Already on Classroom? <asp:HyperLink ID="link" NavigateUrl="~/Accounts/Login.aspx" Text="Sign In" runat="server" /></p>
            <br />
            <asp:Label ID="email_exist" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:CompareValidator ID="conf_password_validator" runat="server" ControlToCompare="password" ControlToValidate="conf_password" ForeColor="Red">Password and Confirm Password must be same.</asp:CompareValidator>          
            <br />
            <asp:CustomValidator ID="password_validator" runat="server" ClientValidationFunction="validatePassword" ControlToValidate="password" ForeColor="Red">Password length must be 6-14 It must contain atleast one lower, one upper and one numeric character.</asp:CustomValidator>
        </div>
    </form>
</body>
</html>
