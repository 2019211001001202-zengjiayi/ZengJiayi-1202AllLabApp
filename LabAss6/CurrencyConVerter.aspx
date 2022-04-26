<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConVerter.aspx.cs" Inherits="LabAss6.CurrencyConVerter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <asp:Label ID="Label1" runat="server" Text="Convert:"></asp:Label>
            <asp:TextBox ID="txtNumber" runat="server" OnTextChanged="txtNumber_TextChanged"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Chinese Yuan to Dollars."></asp:Label>
            <br />
            <br />
             <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" Height="22px" Width="112px" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server">100 Chinese Yuan = 16.00 Dollar</asp:Label>

</body>
</html>
