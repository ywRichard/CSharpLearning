<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Server_Demo2.aspx.cs" Inherits="Itcaster.Web._2017_9_24.Server.Server_Demo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Server_Demo2页面.
        <hr />
        <%Server.Transfer("../UrlReferrer/Demo.html");%>
    </div>
    </form>
</body>
</html>
