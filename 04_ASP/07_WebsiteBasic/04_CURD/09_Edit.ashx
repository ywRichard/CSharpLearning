<%@ WebHandler Language="C#" Class="_09_Edit" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class _09_Edit : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        var id = -1;
        if (int.TryParse(context.Request.QueryString["id"], out id))
        {
            var str = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

            using (var con = new SqlConnection(str))
            {
                var sql = "select * from UserInfo where ID=@ID";
                using (var sda = new SqlDataAdapter(sql, con))
                {
                    sda.SelectCommand.Parameters.Add(new SqlParameter("ID", id));
                    var dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            var filePath = context.Request.MapPath("09_Edit.html");
                            var fileContent = System.IO.File.ReadAllText(filePath);
                            var content = fileContent.Replace("$txtName", dr["UserName"].ToString()).Replace("$txtPwd", dr["UserPass"].ToString()).Replace("$txtEmail", dr["Email"].ToString()).Replace("$txtRegTime", Convert.ToDateTime(dr["RegTime"]).ToString()).Replace("$txtID",id.ToString());

                            context.Response.Write(content);
                        }
                    }
                    else
                    {
                        context.Response.Write("查询失败");
                    }
                }
            }
        }
        else
        {
            context.Response.Write("id错误");
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