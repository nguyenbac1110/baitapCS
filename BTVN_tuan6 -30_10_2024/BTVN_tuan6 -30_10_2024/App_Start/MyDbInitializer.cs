using BTVN_tuan6__30_10_2024.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTVN_tuan6__30_10_2024.App_Start
{
    public class MyDbInitializer : DropCreateDatabaseIfModelChanges<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context)
        {
            context.NhanViens.Add(new NhanVien { Manv = "NV01",Tenquay="Quầy 1",Hoten = "Mai Lan"});
            context.NhanViens.Add(new NhanVien { Manv = "NV02",Tenquay="Quầy 2",Hoten = "Hồng Nhung"});
            context.SaveChanges();

            context.SanPhams.Add(new SanPham { Masp = "SP001",Tensp = "Áo Thun" });
            context.SanPhams.Add(new SanPham { Masp = "SP002",Tensp = "Áo Khoác" });
            context.SanPhams.Add(new SanPham { Masp = "SP003",Tensp = "Quần Jean" });

            context.SaveChanges();
            context.BanHangs.Add(new BanHang { Manv = "NV01" ,Masp = "SP001",Dinhmuc = 30, Slban = 25});
            context.BanHangs.Add(new BanHang { Manv = "NV01" ,Masp = "SP002",Dinhmuc = 30, Slban = 35});
            context.BanHangs.Add(new BanHang { Manv = "NV02" ,Masp = "SP002",Dinhmuc = 30, Slban = 34});
            context.BanHangs.Add(new BanHang { Manv = "NV02" ,Masp = "SP003",Dinhmuc = 30, Slban = 36});
            context.SaveChanges();
            base.Seed(context);
        }
    }
}