<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ders_2.aspx.cs" Inherits="NT_VIZE3.Hafta4.D2.Ders_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
