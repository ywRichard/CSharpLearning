<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02_PageCacheDemo.aspx.cs" Inherits="Itcaster.Web._2017_10_06._02_PageCacheDemo" %>
<%@ OutputCache Duration="5" VaryByParam="*" %>
<%--VaryByParam -> 用来判断传值是否改变，"*"(所有的传送参数)，"ID"(只过滤ID的值)--%>
<%--Duration=5,缓存有效期=5秒--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
