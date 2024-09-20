using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();

            Console.WriteLine("Nhap phan so thu nhat:");
            ps1.Nhap();
            Console.WriteLine("Nhap phan so thu hai:");
            ps2.Nhap();

            Console.Write("Tong: ");
            ps1.TinhTong(ps1, ps2);

            Console.Write("Hieu: ");
            ps1.TinhHieu(ps1, ps2);

            Console.Write("Tich: ");
            ps1.TinhTich(ps1, ps2);

            Console.Write("Thuong: ");
            ps1.TinhThuong(ps1, ps2);

            Console.ReadKey();
        }
    }
}
