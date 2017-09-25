<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Server_Demo.aspx.cs" Inherits="Itcaster.Web._2017_9_24.Server.Server_Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        aaaaaaaa
    <%Server.Execute("../NewList.aspx"); %>
        <iframe src="Server_Demo.aspx"></iframe>
    </div>
    </form>
</body>
</html>
