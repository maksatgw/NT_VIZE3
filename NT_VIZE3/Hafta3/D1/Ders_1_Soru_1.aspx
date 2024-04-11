<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ders_1_Soru_1.aspx.cs" Inherits="NT_VIZE3.Hafta3.D1.Ders_1_Soru_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 61%;
            margin-top: 57px;
        }
        .auto-style3 {
            width: 315px;
        }
        .auto-style4 {
            width: 309px;
        }
        .auto-style5 {
            height: 524px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style5">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" rowspan="6">
                        <asp:BulletedList ID="BulletedList1" runat="server" Height="183px" Width="358px">
                        </asp:BulletedList>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server" Width="121px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button4" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button5" runat="server" Text="Button" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button6" runat="server" Text="Button" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" Height="194px" Width="967px"></asp:Calendar>
    </form>
</body>
</html>
