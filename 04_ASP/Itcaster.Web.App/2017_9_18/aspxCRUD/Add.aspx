<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Itcaster.Web._2017_9_18.aspxCRUD.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%--<!--runat="server", 在服务器端执行Post请求; 如果要执行Get请求, 删掉这个标签重写; 编译器识别到这个标签属性之后会添加一些标签内容，浏览器不能识别标签的这个属性-->--%>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><td>账号</td><td><input type="text" name="txtName" /></td></tr>
                <tr><td>密码</td><td><input type="text" name="txtPwd" /></td></tr>
                <tr><td>邮箱</td><td><input type="text" name="txtEmail" /></td></tr>
                <tr><td colspan="3"><input type="submit" value="添加用户" /></td></tr>
                <span><%=ErrMsg %></span>
            </table>
        </div>
    </form>
</body>
</html>
