<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectNote.aspx.cs" Inherits="SelectNote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="RepeaterTitle" runat="server" OnItemCommand="RepeaterTitle_ItemCommand">
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lblTitle" runat="server" Text='<%#Eval("Title") %>'></asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
