<%@ Page Title="" Language="C#" MasterPageFile="~/2017_10_06/01_Master.Master" AutoEventWireup="true" CodeBehind="01_MasterIndex.aspx.cs" Inherits="Itcaster.Web._2017_10_06._01_MasterIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function show() {
            alert("nihao");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="border:1px solid blue">
    <tr><th>用户名</th><th>密码</th></tr>
     <tr><td>张三</td><td>123</td></tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBottomHoder" runat="server">

   CZBK

</asp:Content>
