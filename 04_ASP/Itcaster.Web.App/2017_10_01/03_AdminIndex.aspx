<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="03_AdminIndex.aspx.cs" Inherits="Itcaster.Web._2017_10_01._03_AdminIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            网页后台管理系统
            欢迎<span style="font-size: 14px; color: red"><%=UserInfo.UserName %></span>登录  Itcast网站后台管理页面.<br />
            <a href="04_Logout.ashx">退出</a>
        </div>
    </form>
</body>
</html>
