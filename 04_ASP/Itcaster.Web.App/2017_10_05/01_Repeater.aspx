<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01_Repeater.aspx.cs" Inherits="Itcaster.Web._2017_10_05._01_Repeater" %>

<%@ Import Namespace="Itcaster.Web.Common" %>
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
                    <th>编号</th>
                    <th>用户名</th>
                    <th>密码</th>
                    <th>邮箱</th>
                    <th>时间</th>
                    <th>删除</th>
                </tr>
                <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ID") %></td>
                            <td><%#Eval("UserName") %></td>
                            <td><%#Eval("UserPass") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("RegTime") %></td>
                            <td>
                                <asp:Button ID="BtnDelete" runat="server" Text="删除" CommandName="btnDeleteUserInfo" CommandArgument='<%#Eval("ID") %>' /></td>
                        </tr>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <tr style="background-color: gray">
                            <td><%#Eval("ID") %></td>
                            <td><%#Eval("UserName") %></td>
                            <td><%#Eval("UserPass") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("RegTime") %></td>
                            <td>
                                <asp:Button ID="BtnDelete" runat="server" Text="删除" CommandName="btnDeleteUserInfo" CommandArgument='<%#Eval("ID") %>' /></td>
                        </tr>
                    </AlternatingItemTemplate>
                    <SeparatorTemplate>
                        <tr>
                            <td colspan="5">
                                <hr />
                            </td>
                        </tr>
                    </SeparatorTemplate>
                </asp:Repeater>
            </table>
            <p>
                <%=PageNumericBar.GetNumericBar(PageIndex,PageCount) %>
            </p>
        </div>

    </form>
</body>
</html>
