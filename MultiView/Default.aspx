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
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">view1</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">view2</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">view3</asp:LinkButton>
                </td>
            </tr>
        </table>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
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
            </asp:View>
            <asp:View ID="View2" runat="server">
                
                <asp:DropDownList ID="SemDropDownList" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="SemDropDownList_SelectedIndexChanged">
                    <asp:ListItem>FY</asp:ListItem>
                    <asp:ListItem>SY</asp:ListItem>
                    <asp:ListItem>TY</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="SubjectDropDownList" runat="server" AutoPostBack="True">
                    <asp:ListItem>English</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>HTML</asp:ListItem>
                </asp:DropDownList>
                
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:BulletedList ID="BulletedList2" runat="server" DisplayMode="HyperLink">
                    <asp:ListItem Value="page.aspx?class=FYBCA">FYBCA</asp:ListItem>
                    <asp:ListItem Value="page.aspx?class=SYBCA">SYBCA</asp:ListItem>
                    <asp:ListItem Value="page.aspx?class=TYBCA">TYBCA</asp:ListItem>
                </asp:BulletedList>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
