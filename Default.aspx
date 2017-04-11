<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summer Note</title>
    <!-- include libraries(jQuery, bootstrap) -->
    <link href="http://netdna.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.css" rel="stylesheet" />
    <script src="http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.4/jquery.js"></script>
    <script src="http://netdna.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.js"></script>

    <!-- include summernote css/js-->
    <link href="http://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.3/summernote.css" rel="stylesheet" />
    <script src="http://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.3/summernote.js"></script>
</head>

<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="summernote" runat="server"></asp:TextBox>
        <asp:Button ID="btnGetHtml" runat="server" Text="Get HTML" OnClientClick="MyHTML();"  OnClick="btnGetHtml_Click"/>
        <asp:HiddenField ID="myHtml" runat="server" />
       
        <script>
            $(document).ready(function () {
                $('#summernote').summernote({
                    height: 300,
                    minHeight: 50,
                    focus: true
                });
            });
            function MyHTML() {
                document.getElementById("myHtml").value = $('#summernote').summernote('code');
            }
        </script>

    </form>
</body>
</html>
