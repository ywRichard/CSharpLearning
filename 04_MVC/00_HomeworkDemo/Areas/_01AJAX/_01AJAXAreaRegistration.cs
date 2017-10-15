using System.Web.Mvc;

namespace _00_HomeworkDemo.Areas._01AJAX
{
    public class _01AJAXAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "_01AJAX";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "_01AJAX_default",
                "_01AJAX/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}