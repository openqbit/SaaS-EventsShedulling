using System.Web;
using System.Web.Mvc;

namespace OpenQbit.EventShedule.Service.WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
