using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itcaster.Web.Common;

namespace Itcaster.Web
{
    /// <summary>
    /// Summary description for ValidationCode
    /// </summary>
    public class ValidationCode : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var code = new ValidateCode();
            code.CreateValidateGraphic(code.CreateValidateCode(6), context);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}