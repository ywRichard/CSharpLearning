<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="05_JsonDemo.aspx.cs" Inherits="Itcaster.Web._2017_10_03._05_JsonDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btn").click(function () {
                //$.post("05_GetJson.ashx", {}, function (data) {
                //    var serverData = $.parseJSON(data);//post -> 返回结果要转成JSON格式
                //    alert(serverData.Name);
                //});
                $.getJSON("05_GetJson.ashx", {}, function (data) {
                    alert(data.Name);//get -> 返回结果就是JSON格式
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" name="name" value="单击" id="btn" />
        </div>
    </form>
</body>
</html>
