using System.Web;
using System.Web.Mvc;

namespace NguyenXuanBac_21103100918_dhti15a15hn_btvn_tuan2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
