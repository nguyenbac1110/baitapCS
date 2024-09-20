using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class KHVN : KhachHang
    {
        public string LoaiKH { get; set; }
        public int DinhMuc { get; set; }
        public KHVN() { }

        public KHVN(string maKH, int soLuong, double donGia, DateTime ngayHoaDon, string hoTenKH, string loaiKH, int dinhMuc)
            : base(maKH, soLuong, donGia, ngayHoaDon, hoTenKH)
        {
            LoaiKH = loaiKH;
            DinhMuc = dinhMuc;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Loai KH: ");
            LoaiKH = Console.ReadLine();
            Console.Write("Dinh Muc: ");
            DinhMuc = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loai KH: {LoaiKH}, Dinh Muc: {DinhMuc}");
        }
    }
}
