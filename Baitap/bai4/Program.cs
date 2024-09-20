using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong hanh khach: ");
            int n = int.Parse(Console.ReadLine());
            HanhKhach[] dskh = new HanhKhach[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin hanh khach thu {i + 1}:");
                HanhKhach hk = new HanhKhach();
                hk.Nhap();
                dskh[i] = hk;
            }
            foreach (HanhKhach hk in dskh)
            {
                hk.Xuat();
                Console.WriteLine($"Tong tien {hk.TongTien()}");
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (dskh[i].TongTien() < dskh[j].TongTien())
                    {
                        HanhKhach temp = dskh[i];
                        dskh[i] = dskh[j];
                        dskh[j] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sach khach hang sau khi sap xep: ");
            foreach (HanhKhach hk in dskh)
            {
                hk.Xuat();
                Console.WriteLine($"Tong tien {hk.TongTien()}");
            }
        }
    }
}
