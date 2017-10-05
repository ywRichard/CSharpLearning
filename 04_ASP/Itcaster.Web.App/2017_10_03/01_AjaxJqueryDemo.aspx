<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01_AjaxJqueryDemo.aspx.cs" Inherits="Itcaster.Web._2017_10_03._01_AjaxJqueryDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.8.3.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnDate").click(function () {
                $.get("02_GetDate.ashx", { "action": "get" }, function (data) {
                    alert(data);
                });
            });//btnDate
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" name="name" value="获取时间" id="btnDate" />
        </div>
    </form>
</body>
</html>
