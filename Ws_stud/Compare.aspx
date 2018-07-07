<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Compare.aspx.cs" Inherits="Compare" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 211px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" border="4">
            <tr>
                <td class="style1">
                    Enter Password</td>
                <td>
                    <asp:TextBox runat="server" ID="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Password_required" runat="server" 
                        ErrorMessage="Password Required" ControlToValidate="Password" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Enter Confirm Password 
                </td>
                <td>
                    <asp:TextBox runat="server" ID="ConfirmPassword"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password Required" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                        ErrorMessage="Password and Confirm Password Should Be Same" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button runat="server" Text="Submit" ID="cmd_submit" />
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
