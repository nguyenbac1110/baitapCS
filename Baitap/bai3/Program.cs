using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        public static VanDongVien[] danhSach;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Chon chuc nang :");
                Console.WriteLine("1. Hien thi thong tin p ");
                Console.WriteLine("2. Nhap mang n van dong vien");
                Console.WriteLine("3. Hien thi danh sach da nhap");
                Console.WriteLine("4. Sap xep mang theo thu tu tang dan");
                Console.WriteLine("5. Thoat chuong trinh");

                int chucNang = int.Parse(Console.ReadLine());

                switch (chucNang)
                {
                    case 1:
                        HienthithongtinP();
                        break;
                    case 2:
                        NhapMang();
                        break;
                    case 3:
                        HienThiMang();
                        break;
                    case 4:
                        SapxepMang();
                        break;
                    case 5:
                        break;
                   
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        }

        private static void SapxepMang()
        {
            
            for (int i = 0; i < danhSach.Length - 1; i++)
            {
                for (int j = i + 1; j < danhSach.Length; j++)
                {
                    if (danhSach[i].Tuoi > danhSach[j].Tuoi)
                    {
                        VanDongVien temp = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = temp;
                    }
                    
                }
            }
            HienThiMang();
            Console.WriteLine("Danh sach da duoc sap xep.");
        }

        private static void HienThiMang()
        {
            Console.WriteLine("\nDanh sach van dong vien da nhap:");
            foreach (VanDongVien vdv in danhSach)
            {
                vdv.HienThi();
            }
        }

        private static void NhapMang()
        {
            Console.Write("Nhap so luong van dong vien: ");
            int n = int.Parse(Console.ReadLine());
            danhSach = new VanDongVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin van dong vien thu {i + 1}:");
                VanDongVien vdv = new VanDongVien();
                vdv.Nhap();
                danhSach[i] = vdv;
            }
        }

        private static void HienthithongtinP()
        {
            VanDongVien p = new VanDongVien("Nguyen Van A", 25, "Chay 100m", 50, 185);
            p.HienThi();
        }
    }
}
