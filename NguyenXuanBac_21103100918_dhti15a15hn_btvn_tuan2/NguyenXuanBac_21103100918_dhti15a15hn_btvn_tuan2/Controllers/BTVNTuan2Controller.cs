using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenXuanBac_21103100918_dhti15a15hn_btvn_tuan2.Controllers
{
    public class BTVNTuan2Controller : Controller
    {
        // GET: BTVNTuan2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestHTMLHelper()
        {
            return View();
        }
        public ActionResult TimUCLN(int a = 0, int b = 0)
        {
            int x = a;
            int y = b;

            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }

            ViewBag.Result = $"UCLN của {a} và {b} là {x}";
            return View();
        }
    }
}