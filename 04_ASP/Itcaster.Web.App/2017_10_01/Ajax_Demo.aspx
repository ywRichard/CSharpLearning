<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax_Demo.aspx.cs" Inherits="CZBK.TestProject.WebApp._2014_11_13.Ajax_Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnGetDate").click(function () {
                var xhr;
                if (XMLHttpRequest) {//表示用户使用的谷歌。
                    xhr = new XMLHttpRequest();
                } else {
                    xhr = new ActiveXObject("Microsoft.XMLHTTP");//兼容IE5，IE6
                }
                xhr.open("get", "Ajax_Get.ashx?name=aaa&pwd=123", true);//第一个:请求方式,二:请求地址,三:是否为异步.
                xhr.send();//开始发送.
                xhr.onreadystatechange = function () {//回调函数.
                    if (xhr.readyState == 4) {//表示服务器将处理结果返回过来
                        if (xhr.status == 200) {//表示服务端处理没有问题。
                            //打印从服务端返回的数据.
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
