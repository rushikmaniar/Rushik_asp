<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowGridView.aspx.cs" Inherits="ShowGridView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" DataSourceID="studdb">
            <Columns>
                <asp:BoundField DataField="empno" HeaderText="empno" SortExpression="empno" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="gender" HeaderText="gender" 
                    SortExpression="gender" />
                <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="studdb" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [emp]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
