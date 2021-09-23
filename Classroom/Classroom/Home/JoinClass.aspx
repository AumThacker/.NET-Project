<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JoinClass.aspx.cs" Inherits="Classroom.JoinClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title> 
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- #include file="../Shared/Home-nav.aspx" -->
        </div>
        <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Class Code</label>
            <asp:TextBox ID="class_code" runat="server" Text="" class="form-control" Width="315px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ccode_required" runat="server" ControlToValidate="class_code" ForeColor="Red">Class code is required.</asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="submit" runat="server" Text="Join" class="btn btn-primary" OnClick="submit_Click" />
        <br />
        <br />
        <asp:Label ID="err" ForeColor="Red" runat="server"></asp:Label>
    </form>
</body>
</html>
