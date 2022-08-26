<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />

        </div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

<table>
  <tr>
    <th>ID</th>
    <th>Contact</th>
    <th>Country</th>
  </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
  <tr>
    <td><%#DataBinder.Eval(Container.DataItem, "id")%></td>
    <td><%#DataBinder.Eval(Container.DataItem, "n")%></td>
    <td><%#DataBinder.Eval(Container.DataItem, "l")%></td>
  </tr>
                
            </ItemTemplate>
        </asp:Repeater>
        </table>

    </form>
</body>
</html>
