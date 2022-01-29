<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yönetmenarama.aspx.cs" Inherits="Proje.Yönetmenarama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Yönetmen Adı"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 41px" Width="190px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" style="margin-left: 71px" Text="Ara" Width="138px" OnClick="Button1_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
