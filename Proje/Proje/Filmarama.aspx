<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Filmarama.aspx.cs" Inherits="Proje.Filmarama1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Filmin Adı"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="22px" style="margin-left: 44px" Width="241px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 43px" Text="Ara" Width="102px" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:BoundField />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
