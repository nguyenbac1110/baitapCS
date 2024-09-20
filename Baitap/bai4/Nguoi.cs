using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }

        public Nguoi() { }

        public Nguoi(string hoTen, string gioiTinh, int tuoi)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Gioi tinh: {GioiTinh}, Tuoi: {Tuoi}");
        }
    }
}
