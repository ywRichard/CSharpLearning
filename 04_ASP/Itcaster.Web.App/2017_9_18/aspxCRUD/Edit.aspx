<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Itcaster.Web._2017_9_18.aspxCRUD.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>用户名</td>
                    <td><input type="text" name="txtName" value="<%=UserDetail.UserName %>" /></td>
                </tr>
                <tr>
                    <td>密码</td>
                    <td><input type="text" name="txtPwd" value="<%=UserDetail.UserPass %>" /></td>
                </tr>
                <tr>
                    <td>邮箱</td>
                    <td><input type="text" name="txtEmail" value="<%=UserDetail.Email %>" /></td>
                </tr>
                <tr>
                    <td>注册时间</td>
                    <td><input type="text" name="txtRegTime" value="<%=UserDetail.RegTime %>" /></td>
                </tr>
                <tr>
                    <td colspan="4"><input type="submit" value="修改用户" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
