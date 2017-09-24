<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewList.aspx.cs" Inherits="Itcaster.Web._2017_9_24.NewList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/tableStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
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
                <%foreach (var userInfo in UserInfoList)
                    {%>
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
        <div>
            <a href="NewList.aspx?pageIndex=1">首页</a>
            <a href="NewList.aspx?pageIndex=<%=PageIndex<=1?1:PageIndex-1 %>">前页</a>
            <a href="NewList.aspx?pageIndex=<%=PageIndex<PageCount?PageIndex+1:PageCount %>">后页</a>
            <a href="NewList.aspx?pageIndex=<%=PageCount %>">末页</a>
        </div>
    </form>
</body>
</html>
