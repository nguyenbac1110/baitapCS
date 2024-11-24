using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class SinhVien
    {
        

        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string LopHoc { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string maSV, string hoTen, int namSinh, string diaChi, string lopHoc)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NamSinh = namSinh;
            DiaChi = diaChi;
            LopHoc = lopHoc;
        }

        public void NhapThongTin()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap lop hoc: ");
            LopHoc = Console.ReadLine();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("Ma SV: {0}, Ho Ten: {1}, Nam Sinh: {2}, Dia Chi: {3}, Lop Hoc: {4}",MaSV, HoTen, NamSinh, DiaChi, LopHoc);
        }
    }
}
