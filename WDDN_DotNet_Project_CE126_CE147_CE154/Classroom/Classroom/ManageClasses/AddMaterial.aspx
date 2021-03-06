<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMaterial.aspx.cs" Inherits="Classroom.ManageClasses.AddMaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Material</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <% if (Convert.ToBoolean(Session["isTeacher"]))
            {%>
        <!-- #include file="../Shared/Teacher-nav.aspx" -->
        <%
            }
            else
            {%>
        <!-- #include file="../Shared/Student-nav.aspx" -->
        <%} %>
        <br />

        <div class="mb-3">
            <asp:Label class="form-label" runat="server" Text="Title"></asp:Label>
            <asp:TextBox ID="title" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="Title is required." ControlToValidate="title" runat="server" ForeColor="Red" />
        </div>
        <div class="form-floating">
            <asp:TextBox ID="desc" TextMode="MultiLine" class="form-control" Style="height: 100px" runat="server"></asp:TextBox>
            <label for="desc">Description</label>
        </div>
        <br />
        <div class="mb-3">
            <asp:Label for="file" ID="Label1" runat="server" Text="Add Material" class="form-label"></asp:Label>
            <asp:FileUpload class="form-control form-control-sm" ID="file" runat="server" />
        </div>
        <div class="input-group mb-3">
            <div class="input-group-text">
                <input class="form-check-input mt-0" onclick="onChecked(this)" type="checkbox" id="is_assignment" value="" runat="server" aria-label="Checkbox for following text input" />
            </div>
            <asp:TextBox Text="Is it an Assignment?" runat="server" ReadOnly="true" class="form-control" aria-label="Text input with checkbox"></asp:TextBox>
        </div>
        <div class="mb-3">
            <asp:Label Text="Deadline" class="form-label" runat="server" />
            <input id="deadline_time" disabled="disabled" type="date" runat="server" class="form-control" />
        </div>
        <div class="mb-3">
            <asp:Button ID="upload" runat="server" Text="Upload" class="btn btn-primary" OnClick="upload_Click" />
        </div>
    </form>
    <script type="text/javascript">
        function onChecked(check) {
            var ele = document.getElementById("deadline_time");
            if (check.checked == true) {
                ele.disabled = false;
            }
            else {
                ele.disabled = true;
            }
        }
    </script>
</body>
</html>
