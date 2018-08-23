<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
                <td>Enter UserName</td>
                <td><asp:TextBox ID="uname" runat="server"></asp:TextBox></td>
            </tr>
            <tr><td colspan=2 align=center><asp:Button ID="cmd_submit" runat="server" Text="Login" PostBackUrl="~/Login.aspx" /></td></tr>
        </table>
    </div>
    </form>
</body>
</html>
