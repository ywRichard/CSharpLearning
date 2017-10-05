<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="03_Register.aspx.cs" Inherits="Itcaster.Web._2017_10_03._03_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.8.3.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#txtName").blur(function () {
                var name = $(this).val();
                if (name!="") {
                    $.post("03_CheckUserName.ashx", { "name": name }, function (data) {
                        $("#errorMsg").text(data);
                    });
                } else {
                    $("#errorMsg").text("用户名不能为空");
                }
            });//blur
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<input type="text" name="txtName" value="" id="txtName" />
            <span id="errorMsg" style="font-size: 14px; color: red;"></span><br />
            密码：<input type="text" name="txtPwd" value="" id="txtPwd" />
        </div>
    </form>
</body>
</html>
