<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02_Login.aspx.cs" Inherits="Itcaster.Web._2017_9_26.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" value="<%=UserName %>" /><br />
            密码:<input type="password" name="txtPwd"/><br />
            <input type="submit" value="登录" />
        </div>
    </form>
</body>
</html>
