<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <h2>My calculator</h2>
    </div>
    <form id="form1" runat="server">
    <div>
        <table border="5" align="center">
            <tr>
                <td colspan="4"><asp:TextBox ID="ansbox" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reset" />
                </td>
            </tr>
            <tr>
                <td align="center"><asp:Button ID="cmdAdd" runat="server" Text="+" 
                        onclick="cmdAdd_Click" /></td>
                <td align="center"><asp:Button ID="cmdSub" runat="server" Text="-" 
                        onclick="cmdSub_Click" /></td>
                <td align="center"><asp:Button ID="cmdMul" runat="server" Text="*" 
                        onclick="cmdMul_Click" /></td>
                <td align="center"><asp:Button ID="cmdDiv" runat="server" Text="/" 
                        onclick="cmdDiv_Click" /></td>
            </tr>
            <tr>
                <td colspan="4" align="center"><asp:Button ID="cmdEqual" runat="server" Text="=" 
                        onclick="cmdEqual_Click" /></td>
            </tr>
            <tr><td>Answer</td><td colspan="3" align="center"><asp:TextBox ID="outputbox" runat="server"></asp:TextBox></td></tr>
        </table>
    </div>
    </form>
</body>
</html>
