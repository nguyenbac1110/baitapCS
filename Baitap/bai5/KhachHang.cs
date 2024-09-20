using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
        public DateTime NgayHoaDon { get; set; }
        public string HoTenKH { get; set; }

        public KhachHang() { }

        public KhachHang(string maKH, int soLuong, double donGia, DateTime ngayHoaDon, string hoTenKH)
        {
            MaKH = maKH;
            SoLuong = soLuong;
            DonGia = donGia;
            NgayHoaDon = ngayHoaDon;
            HoTenKH = hoTenKH;
            ThanhTien = soLuong * donGia;
        }

        public virtual void Nhap()
        {
            Console.Write("Ma KH: ");
            MaKH = Console.ReadLine();
            Console.Write("So Luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Don Gia: ");
            DonGia = double.Parse(Console.ReadLine());
            Console.Write("Ngay Hoa Don (dd/MM/yyyy): ");
            NgayHoaDon = DateTime.Parse(Console.ReadLine());
            Console.Write("Ho Ten KH: ");
            HoTenKH = Console.ReadLine();
            ThanhTien = SoLuong * DonGia;
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ma KH: {MaKH}, So Luong: {SoLuong}, Don Gia: {DonGia}, Thanh Tien: {ThanhTien}, Ngay Hoa Don: {NgayHoaDon.ToShortDateString()}, Ho Ten KH: {HoTenKH}");
        }
    }
}
