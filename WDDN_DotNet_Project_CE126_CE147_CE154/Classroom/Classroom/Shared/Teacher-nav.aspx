<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light" style="background-color: #e3f2fd;">
        <div class="container-fluid">
            <asp:HyperLink class="navbar-brand" runat="server" NavigateUrl="~/Home/home.aspx">Classroom</asp:HyperLink>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <asp:HyperLink runat="server" class="nav-link active" aria-current="page" NavigateUrl="~/Home/home.aspx" Style="text-decoration: none">Home</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink runat="server" class="nav-link active" aria-current="page" NavigateUrl="~/ManageClasses/Stream.aspx" Style="text-decoration: none">Stream</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink runat="server" class="nav-link active" aria-current="page" NavigateUrl="~/ManageClasses/People.aspx" Style="text-decoration: none">People</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink runat="server" class="nav-link active" aria-current="page" Style="text-decoration: none" NavigateUrl="~/ManageClasses/AddMaterial.aspx">Add Material</asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink runat="server" class="nav-link active" aria-current="page" Style="text-decoration: none" NavigateUrl="~/ManageClasses/ViewSubmission.aspx">View Submissions</asp:HyperLink>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
</body>
</html>
