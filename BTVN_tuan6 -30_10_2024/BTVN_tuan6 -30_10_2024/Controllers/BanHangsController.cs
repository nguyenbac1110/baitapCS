using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTVN_tuan6__30_10_2024.Models;

namespace BTVN_tuan6__30_10_2024.Controllers
{
    public class BanHangsController : Controller
    {
        private ShopDbContext db = new ShopDbContext();

        // GET: BanHangs
        public ActionResult Index()
        {
            var banHangs = db.BanHangs.Include(b => b.NhanVien).Include(b => b.SanPham);
            return View(banHangs.ToList());
        }

        // GET: BanHangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanHang banHang = db.BanHangs.Find(id);
            if (banHang == null)
            {
                return HttpNotFound();
            }
            return View(banHang);
        }

        // GET: BanHangs/Create
        public ActionResult Create()
        {
            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay");
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp");
            return View();
        }

        // POST: BanHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Manv,Masp,Dinhmuc,Slban")] BanHang banHang)
        {
            if (ModelState.IsValid)
            {
                db.BanHangs.Add(banHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay", banHang.Manv);
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp", banHang.Masp);
            return View(banHang);
        }

        // GET: BanHangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanHang banHang = db.BanHangs.Find(id);
            if (banHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay", banHang.Manv);
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp", banHang.Masp);
            return View(banHang);
        }

        // POST: BanHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Manv,Masp,Dinhmuc,Slban")] BanHang banHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Manv = new SelectList(db.NhanViens, "Manv", "Tenquay", banHang.Manv);
            ViewBag.Masp = new SelectList(db.SanPhams, "Masp", "Tensp", banHang.Masp);
            return View(banHang);
        }

        // GET: BanHangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanHang banHang = db.BanHangs.Find(id);
            if (banHang == null)
            {
                return HttpNotFound();
            }
            return View(banHang);
        }

        // POST: BanHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BanHang banHang = db.BanHangs.Find(id);
            db.BanHangs.Remove(banHang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string key)
        {

            if (string.IsNullOrEmpty(key))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest) ;
            }
            var banHangs = db.BanHangs.Include(b =>b.NhanVien).Include(b => b.SanPham).Where(b => b.SanPham.Tensp.Contains(key) || b.SanPham.Masp.Contains(key)).ToList();
            return View(banHangs);
        }
        public ActionResult TongSoLuongBanTheoNhanVien()
        {
            var kq = db.BanHangs.GroupBy(b => b.NhanVien).Select(g => new {HoTen = g.Key.Hoten, TongSoLuongBan = g.Sum(b => b.Slban)}).ToList();
            ViewBag.NhanVien = kq.Select(r => r.HoTen).ToList();
            ViewBag.TongSoLuongBan = kq.Select(r => r.TongSoLuongBan).ToList();
            return View();
        }

        public ActionResult BanHangVuotDinhMuc()
        {
            var kq = db.BanHangs.Where(b => b.Slban > b.Dinhmuc).OrderByDescending(b => b.Slban).ToList();
            return View(kq);
        }
        public ActionResult MatHangBanNhieuNhat()
        {
            var kq = db.BanHangs.GroupBy(b => b.SanPham.Tensp).Select(g => new { Tensp = g.Key, TongSoLuong = g.Sum(b => b.Slban) }).OrderByDescending(g => g.TongSoLuong).Take(1).ToList();
            ViewBag.TenSanPham = kq[0].Tensp;
            ViewBag.TongSoLuong = kq[0].TongSoLuong;
            return View();
        }


    }
}
