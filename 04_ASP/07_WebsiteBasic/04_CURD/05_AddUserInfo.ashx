<%@ WebHandler Language="C#" Class="_05_AddUserInfo" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class _05_AddUserInfo : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        var conStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        using (var con = new SqlConnection(conStr))
        {
            using (var cmd = new SqlCommand())
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert UserInfo(UserName,UserPass,RegTime,Email) values(@UserName,@UserPass,@RegTime,@Email)";
                cmd.Parameters.AddWithValue("@UserName", context.Request.Form["txtName"]);
                cmd.Parameters.AddWithValue("@UserPass", context.Request.Form["txtPwd"]);
                cmd.Parameters.AddWithValue("@RegTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@Email", context.Request.Form["txtEmail"]);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    context.Response.Redirect("04_UserInfoList.ashx");//重定向->重新跳转到
                }
                else
                {
                    context.Response.Write("添加失败！");
                }
            }
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}