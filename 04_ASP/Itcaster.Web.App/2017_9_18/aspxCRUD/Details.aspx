<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Itcaster.Web._2017_9_18.aspxCRUD.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/tableStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>用户姓名</td>
                    <td><%=UserDetail.UserName %></td>
                </tr>
                <tr>
                    <td>密码</td>
                    <td><%=UserDetail.UserPass %></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
