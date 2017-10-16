using _02_MVCFilter.Filters;
using System.Web;
using System.Web.Mvc;

namespace _02_MVCFilter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //系统默认的异常处理过滤器，如果使用自定义异常处理，要将如下代码删除。
            filters.Add(new HandleErrorAttribute());

            //在全局中注册过滤器，则所有控制器的所哟行为，都会执行这个过滤器
            //filters.Add(new MyAuthorization());

            //注册全局异常过滤器
            filters.Add(new MyException());
        }
    }
}
