using Baitapvntuan3_2_3_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitapvntuan3_2_3_4.Controllers
{
    public class BTVNController : Controller
    {
        // GET: BTVN
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SoHH(int n = 0)
        {
            ViewBag.n = n;
            return View();
        }
        [HttpPost]
        public ActionResult NhanDL_SoHH(int n)
        {
            ViewBag.n = n;
            return View("SoHH");
        }
        public ActionResult SoCP()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult NhanDL_SoCP(string mangnhap)
        {
            ViewBag.mangnhap = mangnhap;
            return View("SoCP");
        }
        public ActionResult gptb2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NhanDL_gptb2(ptb2 ptb2_)
        {
           ViewBag.a = ptb2_.a;
            ViewBag.b = ptb2_.b;
            ViewBag.c = ptb2_.c;
            return View("gptb2");
        }
    }
}