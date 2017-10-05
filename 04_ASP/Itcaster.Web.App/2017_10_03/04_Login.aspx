<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04_Login.aspx.cs" Inherits="Itcaster.Web._2017_10_03._04_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.7.1.js"></script>
    <script src="../Scripts/jquery-ui-1.8.20.min.js"></script>
    <link href="../css/jquery-ui.min.css" rel="stylesheet" />
    <script type="text/javascript">    
        $(function () {
            checkUserState();//检查用户的状态
            $("#linkLogin").click(function () {
                showDialog();
            });
        });

        function showDialog() {
            $("#dlgLogin").css("display", "block");
            $("#dlgLogin").dialog({
                modal: true,
                buttons: {
                    登录: function () {
                        userLogin();
                        $(this).dialog("close");
                    }
                },
                取消: function () {
                    $(this).dialog("close");
                }
            });
        }

        function checkUserState() {
            $.post("04_CheckUserState.ashx", { "action": "check" }, function (data) {
                var serverData = data.split(':');
                if (serverData[0] == "ok") {
                    $("#divLogin").css("display", "block");
                    $("#linkUserName").text(serverData[1]);
                    $("#divNotLogin").css("display", "none");
                    $("#dlgLogin").css("display", "none");
                } else {
                    $("#divNotLogin").css("display", "block");
                }
            })
        }

        //判断用户名密码
        function userLogin() {
            var userName = $("#txtLoginUserName").val();
            var userPwd = $("#txtLoginPassword").val();
            if (userName == "" || userPwd == "") {
                $("#divLoginMsg").text("用户名密码不能为空！！");
            } else {
                var pars = { "action": "login", "name": userName, "pwd": userPwd };
                $.post("04_CheckUserState.ashx", pars, function (data) {
                    var serverData = data.split(':');
                    if (serverData[0] == "yes") {
                        $("#divLogin").css("display", "block");
                        $("#linkUserName").text(serverData[1]);
                        $("#divNotLogin").css("display", "none");
                        $("#divLoginMsg").text(serverData[1]);
                    } else if (serverData[0] == "no") {
                        $("#divLoginMsg").text(serverData[1]);
                    } else {
                        alert("参数异常");
                    }
                })
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="divLogin" style="display: none">
                <a id="linkUserName"></a>
                <a id="linkLogout" href="javascript:void(0)">注销</a>
            </div>

            <div id="divNotLogin" style="display: none">
                <a href="javascript:void(0)" id="linkLogin">登录</a>
            </div>

            <div id="dlgLogin" style="display: none">
                用户名：<input type="text" id="txtLoginUserName" /><br />
                密码：<input type="password" id="txtLoginPassword" /><br />
                <%--input type="button" id="btnLogin" value="登录" />--%>
            </div>

            <div id="divLoginMsg" style="color: Red"></div>
            <br />
        </div>
    </form>
</body>
</html>
