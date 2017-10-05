<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="09_Ajax_JQuery.aspx.cs" Inherits="Itcaster.Web._2017_10_01._09_Ajax_JQuery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.8.3.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnGetData").click(function () {
                $.post("06_Ajax_Get.ashx", { "name": "yao", "pwd": "123" }, function (data) {
                    //从服务器返回的数据自动填充到回调函数的data参数中
                    var serverData = data.split(':');
                    alert("用户名：" + serverData[0] + ",密码：" + serverData[1]);
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" name="name" value="读取数据" id="btnGetData" />
        </div>
    </form>
</body>
</html>
