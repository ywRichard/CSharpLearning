<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="03_CookieLogin.aspx.cs" Inherits="Itcaster.Web._2017_9_26.CookieLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" /><br />
            密码:<input type="password" name="txtPwd" /><br />
            记住我:<input type="checkbox" name="checkMe" value="1"/><br />
            <input type="submit" value="登录" />
        </div>
    </form>
</body>
</html>
