<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calc.aspx.cs" Inherits="calc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/Jellyfish.jpg">
            <asp:CircleHotSpot NavigateUrl="~/Circle.aspx" Radius="50" X="267" Y="374" />
            <asp:RectangleHotSpot Bottom="100" Left="100" NavigateUrl="~/Rect.aspx" 
                Right="500" Top="10" />
            <asp:PolygonHotSpot Coordinates="15,20,220,150" />
        </asp:ImageMap>
    
    </div>
    </form>
</body>
</html>
