<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="3">
            <tr>
                <td rowspan="4">
                    <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" 
                        Width="100px">
                        <asp:ListItem>Rajkot</asp:ListItem>
                        <asp:ListItem>Surat</asp:ListItem>
                        <asp:ListItem>Baroda</asp:ListItem>
                        <asp:ListItem>Jamnagar</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="cmd_1to2All" runat="server" Text=">>" 
                        onclick="cmd_1to2All_Click" />
                </td>
                <td rowspan="4">
                <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple" Width="100px"></asp:ListBox>
                </td>
            </tr>

            <tr>
               
                <td>
                    <asp:Button ID="cmd_1to2Sel" runat="server" Text=">|" 
                        onclick="cmd_1to2Sel_Click" />
                </td>
                
            </tr>
            <tr>
               
                <td>
                    <asp:Button ID="cmd_2to1Sel" runat="server" Text="|<" 
                        onclick="cmd_2to1Sel_Click" />
                </td>
                
            </tr>
            <tr>
                
                <td>
                    <asp:Button ID="cmd_2to1All" runat="server" Text="<<" 
                        onclick="cmd_2to1All_Click" />
                </td>
                
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
