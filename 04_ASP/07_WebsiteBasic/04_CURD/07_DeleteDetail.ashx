<%@ WebHandler Language="C#" Class="_07_DeleteDetail" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class _07_DeleteDetail : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Delete Details");
        var id = 0;
        if (int.TryParse(context.Request.QueryString["id"], out id))
        {
            var str = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

            using (var con = new SqlConnection(str))
            {
                using (var cmd = new SqlCommand())
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "delete from UserInfo where ID=@ID";
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        context.Response.Redirect("04_UserInfoList.ashx");
                    }
                    else
                    {
                        context.Response.Redirect("08_error.html");
                    }
                }
            }
        }
        else
        {
            context.Response.Write("参数异常");
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