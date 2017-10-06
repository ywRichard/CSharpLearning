using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Caching;

namespace Itcaster.Web._2017_10_06
{
    public partial class _03_FileSystemDependency : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var filePath = Request.MapPath("03_FileContent.txt");
            if (Cache["fileContent"]==null)
            {
                var fileContent = File.ReadAllText(filePath);
                var cacheDepend = new CacheDependency(filePath);
                Cache.Insert("fileContent",fileContent,cacheDepend);
                Response.Write(Cache["fileContent"].ToString());
                Response.Write("数据来自文件");
            }
            else
            {
                Response.Write(Cache["fileContent"].ToString());
                Response.Write("数据来自缓存");
            }
        }
    }
}