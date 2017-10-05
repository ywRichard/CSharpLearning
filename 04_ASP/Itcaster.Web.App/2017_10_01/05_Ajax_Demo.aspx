<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="05_Ajax_Demo.aspx.cs" Inherits="Itcaster.Web._2017_10_01._05_Ajax_Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.8.3.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnGetDate").click(function () {
                var xhr;
                if (XMLHttpRequest) {//兼容chrome, firefox和高版本的IE
                    xhr = new XMLHttpRequest();
                } else {
                    xhr = new ActiveXObject("Microsoft.XMLHTTP");//兼容IE5,IE6
                }
                //xhr.open("get", "06_Ajax_Get.ashx?name=aaa&pwd=123", true);//参数：请求方式；请求地址；是否为异步；get方式
                xhr.open("get", "08_AjaxDemo_Get.aspx?name=aaa&pwd=123", true);
                xhr.send();//开始发送
                xhr.onreadystatechange = function () {//回调函数
                    if (xhr.readyState == 4) {//表示处理结果从服务器返回过来
                        if (xhr.status == 200) {//表示服务端处理没有问题
                            //打印从服务端返回的数据
                            alert(xhr.responseText);
                        }
                    }
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" value="获取时间" id="btnGetDate" />
        </div>
    </form>
</body>
</html>
