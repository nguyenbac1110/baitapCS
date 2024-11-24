using System.Web;
using System.Web.Mvc;

namespace Baitapvntuan3_2_3_4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
