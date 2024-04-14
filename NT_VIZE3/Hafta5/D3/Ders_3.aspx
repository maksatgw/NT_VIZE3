<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Ders_3.aspx.cs" Inherits="NT_VIZE3.Hafta5.D3.Ders_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>

        </div>
    </form>
</body>
</html>
