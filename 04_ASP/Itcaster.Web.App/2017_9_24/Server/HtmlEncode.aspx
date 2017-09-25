<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlEncode.aspx.cs" Inherits="Itcaster.Web._2017_9_24.Server.HtmlEncode" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <%=Server.HtmlEncode("<span style='font-size:14px'>aaaaaaaaa</span>") %> 

        <textarea name="txtContent" rows="20" cols="50"></textarea>
        <input type="submit" value="提交" />
    </div>
    </form>
</body>
</html>
