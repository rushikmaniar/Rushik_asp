<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiCookie.aspx.cs" Inherits="MultiCookie" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="5">
            <tr>
                <td>
                    Enter Name :
                </td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Enter Age :
                </td>
                <asp:HiddenField ID="cookiename" runat="server" />
                <td>
                    <asp:TextBox ID="age" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Enter Contact :
                </td>
                <td>
                    <asp:TextBox ID="Contact" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button runat="server" ID="cmd_cookie" Text="Create Cookie" OnClick="cmd_cookie_Click" />
                </td>
                <td align="center">
                    <asp:Button runat="server" ID="cmd_submit" Text="Submit" PostBackUrl="~/MultivaluecookieView.aspx" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
