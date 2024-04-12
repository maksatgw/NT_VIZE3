<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ders_3.aspx.cs" Inherits="NT_VIZE3.Hafta4.D3.Ders_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
        </div>
    </form>
</body>
</html>
