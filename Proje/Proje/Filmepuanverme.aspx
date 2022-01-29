<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Filmepuanverme.aspx.cs" Inherits="Proje.Filmepuanverme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Film"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="31px" style="margin-left: 122px" Width="194px"></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="Label2" runat="server" Text="Kategori"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="35px" style="margin-left: 83px" Width="193px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Yönetmen"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="35px" style="margin-left: 68px" Width="195px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Senarist"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="34px" style="margin-left: 90px" Width="194px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Puan"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Height="36px" style="margin-left: 108px" Width="189px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" style="margin-left: 119px" Text="Puan Ver" Width="155px" OnClick="Button1_Click1" />
        </p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
