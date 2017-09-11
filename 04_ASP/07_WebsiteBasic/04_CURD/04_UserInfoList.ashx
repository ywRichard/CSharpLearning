<%@ WebHandler Language="C#" Class="_04_UserInfoList" %>

using System;
using System.Web;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.IO;

public class _04_UserInfoList : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        var conStr = System.Configuration.ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        using (var conn = new SQLiteConnection(conStr))
        {
            var dt = new DataTable();
            using (var adapter = new SQLiteDataAdapter("select MemmberId,MemName,MemMobilePhone,MemBirthdaty from UserInfo", conn))
            {
                adapter.Fill(dt);

                var sb = new StringBuilder();
                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowDetail.ashx?id={5}'>详细</a></td></tr>", dr["MemmberId"], dr["MemName"], dr["MemMobilePhone"], Convert.ToDateTime(dr["MemBirthdaty"]).ToShortDateString());
                }
                var filePath = context.Request.MapPath("UserInfoList.html");
                var fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.Replace("$tbody", sb.ToString());
                context.Response.Write(fileContent);
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