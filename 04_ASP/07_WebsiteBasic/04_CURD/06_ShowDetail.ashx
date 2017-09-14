<%@ WebHandler Language="C#" Class="_06_ShowDetail" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
public class _06_ShowDetail : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        int id;
        if (int.TryParse(context.Request.QueryString["id"], out id))//获取URL的传值
        {
            var conStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (var con = new SqlConnection(conStr))
            {
                using (var sda = new SqlDataAdapter("select * from UserInfo where ID=@ID", con))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@ID", id);
                    var dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            var filePath = context.Request.MapPath("06_ShowDetail.html");
                            var fileContent = System.IO.File.ReadAllText(filePath);
                            var str = fileContent.Replace("$name", dr["UserName"].ToString()).Replace("$pwd", dr["UserPass"].ToString());
                            context.Response.Write(str);
                        }
                    }
                    else
                    {
                        context.Response.Write("没有此数据");
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