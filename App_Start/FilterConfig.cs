using System.Web;
using System.Web.Mvc;

namespace CCC_JB_10793878
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
