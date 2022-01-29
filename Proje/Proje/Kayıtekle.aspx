<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kayıtekle.aspx.cs" Inherits="Proje.Kayıtekle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="30px" style="margin-left: 40px" Width="189px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Adı"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="30px" style="margin-left: 118px" Width="199px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Soyadı"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="31px" style="margin-left: 93px" Width="185px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Şifre"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="36px" style="margin-left: 110px" Width="178px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 47px" Text="Kullanıcıyı Ekle" Width="128px" />
    </form>
</body>
</html>
