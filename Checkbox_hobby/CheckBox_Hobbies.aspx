<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBox_Hobbies.aspx.cs"
    Inherits="CheckBox_Hobbies" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="2">
            <tr>
                <td>
                    Enter Your Name:
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="uname" ErrorMessage="RegularExpressionValidator" 
                        ValidationExpression="^\d{10}$"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" ID="uname"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Hobbies:
                </td>
                <td>
                    <asp:CheckBox runat="server" ID="MCA"  Text="MCA" />
                    <asp:CheckBox runat="server" ID="BCA"  Text="BCA" />
                    <asp:CheckBox runat="server" ID="Mscit" Text="Mscit" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center" class="style1">
                    <asp:Button runat="server" ID="cmd_submit" PostBackUrl="~/Default.aspx" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
