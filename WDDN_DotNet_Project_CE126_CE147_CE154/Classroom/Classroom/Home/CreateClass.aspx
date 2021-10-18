<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateClass.aspx.cs" Inherits="Classroom.CreateClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Class</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        form{
            margin-top: 5px;
            margin-left: 5px;
        }
    </style>
</head>
<body>
    <div>
        <!-- #include file="../Shared/Home-nav.aspx" -->
    </div>
    <form id="form1" runat="server">
        <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Class Name</label>
            <asp:TextBox ID="class_name" runat="server" Text="" class="form-control" Width="315px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="cname_required" runat="server" ControlToValidate="class_name" ForeColor="Red">Class name is required.</asp:RequiredFieldValidator>
        </div>
        <div class="mb-3">
            <label for="exampleInputPassword1" class="form-label">Subject Name</label>
            <asp:TextBox ID="subject_name" runat="server" Text="" class="form-control" Width="315px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="sname_required" runat="server" ControlToValidate="subject_name" ForeColor="Red">Subject name is required.</asp:RequiredFieldValidator>
        </div>
        
        <asp:Button ID="submit" runat="server" Text="Create" class="btn btn-primary" OnClick="submit_Click"/>
    </form>
</body>
</html>
