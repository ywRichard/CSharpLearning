using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_01
{
    /// <summary>
    /// Summary description for _02_Validation
    /// </summary>
    public class _02_Validation : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var validate = new Common.ValidateCode();
            var code = validate.CreateValidateCode(4);
            context.Session["code"] = code;
            validate.CreateValidateGraphic(code, context);
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