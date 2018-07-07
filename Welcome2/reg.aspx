<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="reg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="2">
            <tr>
                <td>Enter Your Name</td>
                <td><asp:TextBox ID="uname" runat="server"></asp:TextBox></td>
                <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                    ControlToValidate="uname"
                    ErrorMessage="Name is a required field."
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
               
            </tr>
            <tr>
                <td colspan="2" align="center">
                   <asp:Button ID="cmd_submit" runat="server" PostBackUrl="" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
