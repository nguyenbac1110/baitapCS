using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class VanDongVien
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string MonThiDau { get; set; }
        public float CanNang { get; set; }
        public float ChieuCao { get; set; }
        public VanDongVien() { }

        
        public VanDongVien(string hoTen, int tuoi, string monThiDau, float canNang, float chieuCao)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            MonThiDau = monThiDau;
            CanNang = canNang;
            ChieuCao = chieuCao;
        }

        
        ~VanDongVien() { }

       public void Nhap()
        {
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Mon thi dau: ");
            MonThiDau = Console.ReadLine();
            Console.Write("Can nang: ");
            CanNang = float.Parse(Console.ReadLine());
            Console.Write("Chieu cao: ");
            ChieuCao = float.Parse(Console.ReadLine());

        }
        public void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Tuoi: {Tuoi}, Mon thi dau: {MonThiDau}, Can nang: {CanNang}, Chieu cao: {ChieuCao}");
        }
    }
}
