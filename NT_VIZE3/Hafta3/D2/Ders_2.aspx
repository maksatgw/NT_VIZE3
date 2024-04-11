<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ders_2.aspx.cs" Inherits="NT_VIZE3.Hafta3.D2.Ders_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 294px">
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <asp:CheckBox ID="CheckBox2" runat="server" />
            <asp:CheckBox ID="CheckBox3" runat="server" />
            <asp:CheckBox ID="CheckBox4" runat="server" />
            <asp:CheckBox ID="CheckBox5" runat="server" />
            <asp:CheckBox ID="CheckBox6" runat="server" />
            <asp:CheckBox ID="CheckBox7" runat="server" />
        </div>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="251px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="209px" />
    </form>
</body>
</html>
