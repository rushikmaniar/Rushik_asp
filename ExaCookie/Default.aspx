<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="4">
            <tr>
                <td>
                    Enter Name
                </td>
                <td>
                    <asp:TextBox ID="uname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center"><asp:Button ID="createcookiebtn" runat="server" 
                        Text="Create Cookie" onclick="createcookiebtn_Click" /></td>
                <td><a href="viewcookie.aspx">View Cookie</a></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
