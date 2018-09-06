<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Studreg.aspx.cs" Inherits="Studreg"  Debug="true" %>

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
                    Rollno
                </td>
                <td>
                    <asp:TextBox ID="Rollno" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RollnoReg" runat="server" 
                        ControlToValidate="Rollno" ErrorMessage="Rollno No Not Valid" ForeColor="Red" 
                        ValidationExpression="^[\d]*$"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredRollno" runat="server" 
                        ControlToValidate="Rollno" ErrorMessage="Rollno Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Name
                </td>
                  <td>
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredName" runat="server" 
                        ControlToValidate="Name" ErrorMessage="Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Age
                </td>
                <td>
                    <asp:TextBox ID="Age" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredAge" runat="server" 
                        ControlToValidate="Age" ErrorMessage="Age Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="AgeReg" runat="server" 
                        ControlToValidate="Age" ErrorMessage="Age Not Valid" ForeColor="Red" 
                        ValidationExpression="^[\d]*$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
Gender
                </td>
                <td>
                    <asp:RadioButton ID="Male" GroupName="Gender" Text="Male" runat="server" 
                        Checked="True" />
                    <asp:RadioButton ID="Female" GroupName="Gender" Text="Female" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="center">
                <asp:Button ID="cmd_submit" Text="Save" runat="server" PostBackUrl="" 
                        onclick="cmd_submit_Click" />
                <asp:Button ID="Clear" Text="Clear" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
