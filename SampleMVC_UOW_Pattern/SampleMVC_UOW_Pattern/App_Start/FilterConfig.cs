using System.Web;
using System.Web.Mvc;

namespace SampleMVC_UOW_Pattern
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
