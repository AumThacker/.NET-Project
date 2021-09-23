<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Classroom.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .panel{
            width:auto;
            height:auto;
            border: 1px solid #e3f2fd;
        }
        .panel-heading{
            background-color:lightskyblue;
            height:50%;
            padding:1%;
        }
        .panel-body{
            padding:1%;
        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <div>
            <!-- #include file="../Shared/Home-nav.aspx" -->
        </div>
        <br />  
        <% for (int c = 0; c < classes.Length; c++)
           {
           %>
                
           <a href="../ManageClasses/Stream.aspx?class_code=<%=classes[c].ClassCode %>" style="text-decoration: none; color: black">
               <div class="panel">
                   <div class="panel-heading">
                       <%=classes[c].ClassName %>
                   </div>
                   <div class="panel-body">
                       <%=classes[c].SubjectName %>
                   </div>
               </div>
           </a>
           <br />
           <%
           }
        %>
        <br />     
    </form>

</body>
</html>
