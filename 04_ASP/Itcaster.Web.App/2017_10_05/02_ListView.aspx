<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02_ListView.aspx.cs" Inherits="Itcaster.Web._2017_10_05._02_ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" DataKeyNames="ID">
            <AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="UserPassLabel" runat="server" Text='<%# Eval("UserPass") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegTimeLabel" runat="server" Text='<%# Eval("RegTime") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="UserPassTextBox" runat="server" Text='<%# Bind("UserPass") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="RegTimeTextBox" runat="server" Text='<%# Bind("RegTime") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="UserPassTextBox" runat="server" Text='<%# Bind("UserPass") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="RegTimeTextBox" runat="server" Text='<%# Bind("RegTime") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="UserPassLabel" runat="server" Text='<%# Eval("UserPass") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegTimeLabel" runat="server" Text='<%# Eval("RegTime") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server">ID</th>
                                    <th runat="server">UserName</th>
                                    <th runat="server">UserPass</th>
                                    <th runat="server">RegTime</th>
                                    <th runat="server">Email</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="False" ShowNextPageButton="false"/>
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="False" ShowLastPageButton="True" ShowPreviousPageButton="false"/>
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="UserPassLabel" runat="server" Text='<%# Eval("UserPass") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegTimeLabel" runat="server" Text='<%# Eval("RegTime") %>' />
                    </td>
                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Itcaster.Web.Model.UserInfo" DeleteMethod="DeleteEntityModel" InsertMethod="InsertEntityModel" SelectMethod="GetEntityList" TypeName="Itcaster.Web.BLL.UserInfoBLL" UpdateMethod="UpdateEntityModel"></asp:ObjectDataSource>
    </form>
</body>
</html>
