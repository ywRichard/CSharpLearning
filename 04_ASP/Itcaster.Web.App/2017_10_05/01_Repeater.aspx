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
                <!--Repeater,对数据源进行遍历输出，并设置显示格式-->
                <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
                    <ItemTemplate><!--相当于foreach中的{},决定了每条数据以什么格式显示-->
                        <tr>
                            <td><%#Eval("ID") %></td><!--Eval("ID")表示该位置显示ID的属性-->
                            <td><%#Eval("UserName") %></td>
                            <td><%#Eval("UserPass") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("RegTime") %></td>
                            <td>
                                <asp:Button ID="BtnDelete" runat="server" Text="删除" CommandName="btnDeleteUserInfo" CommandArgument='<%#Eval("ID") %>' /></td>
                        </tr>
                    </ItemTemplate>
                    <AlternatingItemTemplate><!--设置隔行显示不同的风格，<ItemTemplate>显示奇数行，<AlternatingItemTemplate>显示偶数行-->
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
                    <SeparatorTemplate><!--设置两项数据间的分隔符;<HeaderTemplate>,<FooterTemplate>，头，尾显示格式，分别显示在数据前和数据后-->
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
