<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Senaristarama.aspx.cs" Inherits="Proje.Senaristarama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Senarist İsmi"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="29px" style="margin-left: 26px" Width="186px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" style="margin-left: 92px" Text="Ara" Width="105px" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
