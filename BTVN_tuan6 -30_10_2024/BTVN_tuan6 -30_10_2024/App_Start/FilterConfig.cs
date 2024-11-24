using System.Web;
using System.Web.Mvc;

namespace BTVN_tuan6__30_10_2024
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
