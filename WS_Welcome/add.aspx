<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="Default2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
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
            
            <tr>
                <td colspan="2" align="center">              
                        <input type="radio" name="operation" value="ADD">ADD
                        <input type="radio" name="operation" value="SUB">SUB
                        <input type="radio" name="operation" value="MUL">MUL
                        <input type="radio" name="operation" value="DIV">DIV                                          
                </td>               
            </tr>
            -->
            <tr>
            <td colspan="2" align="center">
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_add" Text="Add" runat="server" />
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_sub" Text="SUB" runat="server" />
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_mul" Text="MUL" runat="server" />
                    <asp:Button PostBackUrl="~/calc.aspx" ID="btn_div" Text="DIV" runat="server" />
                </td>
            </tr>
            
           <!-- <tr>
                <td colspan="2" align="center">
                    <asp:Button CssClass="btn-lg btn-primary" PostBackUrl="~/calc.aspx" ID="cmd_submit" Text="submit" runat="server" />
                </td>
            </tr> -->
        </table>
    </div>
    </form>
    
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>
   
</body>
</html>
