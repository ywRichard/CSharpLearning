using System.Web.Mvc;

namespace _01_MVCBasic.Areas.NewsInfo
{
    public class NewsInfoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NewsInfo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NewsInfo_default",
                "NewsInfo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}