<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Itcaster.Web._2017_9_18.aspxCRUD.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/tableStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <a href="Add.aspx">添加用户</a>
        <div>
            <table>
                <tr>
                    <th>编号</th>
                    <th>用户名</th>
                    <th>密码</th>
                    <th>时间</th>
                    <th>邮箱</th>
                    <th>详细</th>
                    <th>删除</th>
                    <th>编辑</th>
                </tr>
                <%--<%=StrHtml %>--%>
                <%foreach (var userInfo in UserInfoList){%>
                <tr>
                    <td><%=userInfo.ID%></td>
                    <td><%=userInfo.UserName%></td>
                    <td><%=userInfo.UserPass%></td>
                    <td><%=userInfo.RegTime%></td>
                    <td><%=userInfo.Email%></td>
                    <td><a href='Details.aspx?id=<%=userInfo.ID%>'>详细</a></td>
                    <td><a href='Delete.ashx?id=<%=userInfo.ID%>'>删除</a></td>
                    <td><a href='Edit.aspx?id=<%=userInfo.ID%>'>编辑</a></td>
                </tr>
                <%} %>
            </table>
        </div>
    </form>
</body>
</html>
