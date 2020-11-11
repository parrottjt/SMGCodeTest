using System.Web;
using System.Web.Mvc;

namespace SMGCodeTest.TinyURLWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
