<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="07_Ajax_Post.aspx.cs" Inherits="Itcaster.Web._2017_10_01._07_Ajax_Post" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.8.3.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnGetDate").click(function () {
                var xhr;
                if (XMLHttpRequest) {
                    xhr = new XMLHttpRequest();
                } else {
                    xhr = new ActiveXObject("Microsoft.XMLHTTP");
                }
                xhr.open("post", "06_Ajax_Get.ashx", true);
                xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");

                xhr.send("name=zhangsan&pwd=123");
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4) {
                        if (xhr.status == 200) {
                            alert(xhr.responseText);
                        }
                    }
                }//onreadystatechange
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" name="name" value="获取时间" id="btnGetDate" />
        </div>
    </form>
</body>
</html>
