<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="_Default" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
    <div>
        <table border="2">
            <tr>
                <td>Enter Your Name</td>
                <td><asp:TextBox ID="uname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                   <asp:Button ID="cmd_submit" runat="server" PostBackUrl="~/Welcome.aspx" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>