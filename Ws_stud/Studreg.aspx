<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Studreg.aspx.cs" Inherits="Studreg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="Table1" border="4">
            <tr>
                <td>
                    Enter No
                </td>
                <td>
                    <asp:TextBox runat="server" ID="StudNo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="StudNo" ErrorMessage="Stud No is Required" ForeColor="Red" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="StudNo" ErrorMessage="Entered No Invalid" ForeColor="Red" 
                        SetFocusOnError="True" ValidationExpression="^\d$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Enter Name
                </td>
                <td>
                    <asp:TextBox runat="server" ID="StudName"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="StudName" ErrorMessage="Name is Required" ForeColor="Red" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Year
                </td>
                <td>
                    <asp:RadioButton runat="server" ID="FY" GroupName="Year" Text="FY" /><asp:RadioButton
                        runat="server" ID="SY" GroupName="Year" Text="SY" /><asp:RadioButton runat="server"
                            ID="TY" GroupName="Year" Text="TY" />
                </td>
               
            </tr>
            <tr>
                <td>
                    Age
                </td>
                <td>
                    <asp:TextBox ID="age" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="age" ErrorMessage="Age is Required" ForeColor="Red" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" 
                        ErrorMessage="Age should be between 18 to 21" ForeColor="Red" MaximumValue="21" 
                        MinimumValue="18"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="email" ErrorMessage="Email is Required" ForeColor="Red" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                        ControlToValidate="email" ErrorMessage="Invalid Email" ForeColor="Red" 
                        SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    contact
                </td>
                <td>
                    <asp:TextBox ID="contact" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="contact" ErrorMessage="Contact is Required" ForeColor="Red" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                        ControlToValidate="contact" ErrorMessage="Invalid Contact" ForeColor="Red" 
                        SetFocusOnError="True" ValidationExpression="^\d{10}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Hobbies
                </td>
                <td>
                    <asp:CheckBoxList ID="hobbies" runat="server">
                        <asp:ListItem>Music</asp:ListItem>
                        <asp:ListItem>sports</asp:ListItem>
                        <asp:ListItem>Singing</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center"><asp:Button runat="server" Text="Submit" 
                        PostBackUrl="~/View_Stud.aspx" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
