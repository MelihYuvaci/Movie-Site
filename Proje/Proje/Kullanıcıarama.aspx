<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kullanıcıarama.aspx.cs" Inherits="Proje.Kullanıcıarama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Kullanıcı İsmi"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="33px" style="margin-left: 22px" Width="194px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Height="40px" Text="Ara" Width="146px" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
