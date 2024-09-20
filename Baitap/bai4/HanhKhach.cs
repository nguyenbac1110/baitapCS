using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class HanhKhach : Nguoi
    {
        public VeMayBay[] Ve { get; set; }
        public int SoLuong { get; set; }

        public HanhKhach() { }

        public HanhKhach(string hoTen, string gioiTinh, int tuoi, int soLuong) : base(hoTen, gioiTinh, tuoi)
        {
            SoLuong = soLuong;
            Ve = new VeMayBay[soLuong];
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so luong ve: ");
            SoLuong = int.Parse(Console.ReadLine());
            Ve = new VeMayBay[SoLuong];
            for (int i = 0; i < SoLuong; i++)
            {
                Console.WriteLine($"Nhap thong tin ve thu {i + 1}:");
                Ve[i] = new VeMayBay();
                Ve[i].Nhap();
            }
        }

        public new void Xuat()
        {
            base.Xuat();
            for (int i = 0; i < SoLuong; i++)
            {
                Console.WriteLine($"Thong tin ve thu {i + 1}:");
                Ve[i].Xuat();
            }
        }

        public double TongTien()
        {
            double tongTien = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                tongTien += Ve[i].GetGiaVe();
            }
            return tongTien;
        }




    }
}
