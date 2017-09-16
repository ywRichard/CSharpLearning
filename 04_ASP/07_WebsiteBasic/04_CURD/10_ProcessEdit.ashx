<%@ WebHandler Language="C#" Class="_10_ProcessEdit" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class _10_ProcessEdit : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        var id = -1;
        if (int.TryParse(context.Request.Form["txtID"], out id))
        {
            var str = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (var con = new SqlConnection(str))
            {
                var sql = "update UserInfo set UserName=@UserName,UserPass=@UserPass,RegTime=@RegTime,Email=@Email where ID=@id";
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("@UserName", context.Request.Form["txtName"]));
                    cmd.Parameters.Add(new SqlParameter("@UserPass", context.Request.Form["txtPwd"]));
                    cmd.Parameters.Add(new SqlParameter("@RegTime", Convert.ToDateTime(context.Request.Form["txtRegTime"])));
                    cmd.Parameters.Add(new SqlParameter("@Email", context.Request.Form["txtEmail"]));
                    cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(id)));

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        context.Response.Redirect("04_UserInfoList.ashx");
                    }
                    else
                    {
                        context.Response.Write("修改失败");
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