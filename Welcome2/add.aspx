<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <table border="2" class="table col-sm-4">
            <tr>
                <td>
                    Enter 1st No
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="txt1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Enter 2nd No
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="txt2" runat="server"></asp:TextBox>
                </td>
            </tr>
           
           <!--
            <tr>
                <td colspan="2" align="center">
                   
                    <select id="operation" name="operation">
                        <option value="ADD">ADD</option>
                        <option value="SUB">SUB</option>
                        <option value="MUL">MUL</option>
                        <option value="DIV">DIV</option>
                    </select>
                </td>
               
            </tr>
            -->
            <tr>
                <td colspan="2" align="center">
                        <asp:RadioButton ID="ADD" runat="server" Text="ADD" GroupName="operation" />
                        <asp:RadioButton ID="SUB" runat="server" Text="SUB" GroupName="operation" />
                        <asp:RadioButton ID="MUL" runat="server" Text="MUL" GroupName="operation" />
                        <asp:RadioButton ID="DIV" runat="server" Text="DIV" GroupName="operation" />
                     <!--             
                        <input type="radio" name="operation" value="ADD">ADD
                        <input type="radio" name="operation" value="SUB">SUB
                        <input type="radio" name="operation" value="MUL">MUL
                        <input type="radio" name="operation" value="DIV">DIV     -->                                     
                </td>               
            </tr>
            
           <!--  <tr>
            <td colspan="2" align="center">
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_add" Text="Add" runat="server" />
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_sub" Text="SUB" runat="server" />
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_mul" Text="MUL" runat="server" />
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_div" Text="DIV" runat="server" />
                </td>
            </tr> -->
            
            <tr>
                <td colspan="2" align="center">
                    <asp:Button CssClass="btn-lg btn-primary" PostBackUrl="~/calc.aspx" ID="cmd_submit" Text="submit" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
