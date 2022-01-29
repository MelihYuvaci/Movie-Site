<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yöneticigiriş.aspx.cs" Inherits="Proje.Yöneticigiriş" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Tc Kimlik Numarası"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="31px" style="margin-left: 43px" Width="217px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="30px" style="margin-left: 43px" Width="188px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" style="margin-left: 72px" Text="Giriş" Width="119px" OnClick="Button1_Click" />
    </form>
</body>
</html>
