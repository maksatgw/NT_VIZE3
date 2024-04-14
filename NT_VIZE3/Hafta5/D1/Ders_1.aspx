<%@ Page Language="C#"  UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Ders_1.aspx.cs" Inherits="NT_VIZE3.Hafta5.D1.Ders_1" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
