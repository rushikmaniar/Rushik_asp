<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Empreg.aspx.cs" Inherits="Empreg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2 align="center">ADD OR Edit Employee</h2>
        <table align="center" border="10" cellpadding="10" cellspacing="10">
            <tr>
                <td>
                    Emp No
                </td>
                <td>
                    <asp:TextBox ID="empno" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    Emp Name
                </td>
                <td>
                    <asp:TextBox ID="empname" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    Gender
                </td>
                <td>
                    <asp:RadioButton ID="Male" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="Female" runat="server" GroupName="Gender" Text="Female" />
                </td>
            </tr>

            <tr>
                <td>
                    Designation
                </td>
                <td>
                    <asp:DropDownList ID="design" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <asp:HiddenField ID="operation" Value="add" runat="server" />
            <asp:HiddenField ID="updateID" Value="0" runat="server" />
            <tr>
                <td colspan="2" align="center"><asp:Button runat="server" ID="cmd_submit" Text="SAVE" PostBackUrl="~/operation.aspx"/></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
