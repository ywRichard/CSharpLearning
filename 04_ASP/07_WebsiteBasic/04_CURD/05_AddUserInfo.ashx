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

        using (var con=new SqlConnection(conStr))
        {
            using (var cmd=new SqlCommand())
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert UserInfo(FirstName,PostalCode,HireDate,HomePhone) values(@FirstName,@PostalCode,@HireDate,@HomePhone)";
                cmd.Parameters.AddWithValue("@FirstName",context.Request.Form["txtName"]);
                cmd.Parameters.AddWithValue("@PostalCode",context.Request.Form["txtCode"]);
                cmd.Parameters.AddWithValue("@HireDate",DateTime.Now);
                cmd.Parameters.AddWithValue("@HomePhone",context.Request.Form["txtHomePhone"]);

                if (cmd.ExecuteNonQuery()>0)
                {
                    context.Response.Redirect("UserInfoList.ashx");//重定向->重新跳转到
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