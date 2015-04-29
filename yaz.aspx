<%@ Page Language="C#" AutoEventWireup="true" CodeFile="yaz.aspx.cs" Inherits="yaz" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 23px;
            width: 471px;
        }
        .style2
        {
            width: 121px;
        }
        .style3
        {
            height: 23px;
            width: 121px;
        }
        .style4
        {
            width: 471px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:525px; height: 319px;">
            <tr>
                <td class="style2">
                    Mesajı Yazan</td>
                <td class="style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Mesaj Başlığı</td>
                <td class="style1">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Mesaj</td>
                <td class="style4">
                    <asp:TextBox ID="TextBox3" runat="server" Height="201px" TextMode="MultiLine" 
                        Width="348px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style4" align="center">
                    <asp:Button ID="Button1" runat="server" PostBackUrl="~/kaydet.aspx" 
                        Text="Gönder" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
