using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class KHNN : KhachHang
    {
        public string QuocTich { get; set; }
        public KHNN() { }

        public KHNN(string maKH, int soLuong, double donGia, DateTime ngayHoaDon, string hoTenKH, string quocTich): base(maKH, soLuong, donGia, ngayHoaDon, hoTenKH)
        {
            QuocTich = quocTich;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Quoc Tich: ");
            QuocTich = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Quoc Tich: {QuocTich}");
        }
    }
}
