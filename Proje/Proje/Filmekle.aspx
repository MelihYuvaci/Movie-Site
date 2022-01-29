<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Filmekle.aspx.cs" Inherits="Proje.Filmekle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Film Adı"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="31px" style="margin-left: 94px" Width="210px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Film Kategorisi"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="30px" style="margin-left: 43px" Width="204px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Film Yönetmeni"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="29px" style="margin-left: 41px" Width="201px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Film Senaristi"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="29px" style="margin-left: 57px" Width="195px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" style="margin-left: 98px" Text="Ekle" Width="155px" />
    </form>
</body>
</html>
