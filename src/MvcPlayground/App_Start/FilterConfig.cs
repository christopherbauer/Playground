using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPlayground
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new OrderItemCountActionFilterAttribute());
            filters.Add(new OrderItemCountFilter());
        }
    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class OrderItemCountActionFilterAttribute : ActionFilterAttribute
    {
    }

    public class OrderItemCountFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var attribute = GlobalFilters.Filters.Select(filter => filter.Instance).OfType<OrderItemCountActionFilterAttribute>();
            if (attribute.All(o => o.GetType() != typeof(OrderItemCountActionFilterAttribute)))
            {
                return;
            }

            throw new Exception("It worked!");
        }

    }
}
