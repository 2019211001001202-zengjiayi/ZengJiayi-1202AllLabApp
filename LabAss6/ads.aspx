<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ads.aspx.cs" Inherits="LabAss6.ads" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 178px;
            width: 343px;
        }
        .auto-style1 {
            height: 117px;
            width: 745px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            Ads 1
        </div>
        <div>
            <h2>This is my advertisement page </h2>
        </div>
        <div class="auto-style1">
            Ads 2
        </div>
        <asp:AdRotator ID="AdRotator1" runat="server" OnAdCreated="AdRotator1_AdCreated" AdvertisementFile="~/App_Data/AdListXMLFile.xml" KeywordFilter="ads2" />
    </form>
</body>
</html>
