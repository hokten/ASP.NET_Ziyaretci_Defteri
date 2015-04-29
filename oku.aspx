<%@ Page Language="C#" AutoEventWireup="true" CodeFile="oku.aspx.cs" Inherits="oku" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .tablo
        {
            margin-left: auto;
            margin-right: auto;
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server" BorderWidth="1px" CssClass="tablo" 
            Width="400px">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
