using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public int NamSinh { get; set; }
        public double DiemTongKet { get; set; }

        public SinhVien() {
            HoTen = "";
            QueQuan = "";
            NamSinh = 0;
            DiemTongKet = 0;
        }
        public SinhVien(string hoTen, string queQuan, int namSinh, double diemTongKet)
        {
            HoTen = hoTen;
            QueQuan = queQuan;
            NamSinh = namSinh;
            DiemTongKet = diemTongKet;
        }
        public void Nhap()
        {
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem tong ket: ");
            DiemTongKet = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Ho va ten: {HoTen}");
            Console.WriteLine($"Que quan: {QueQuan}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Diem tong ket: {DiemTongKet}");
        }
    }
}
