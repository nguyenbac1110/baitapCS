using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class Program
    {
        static ArrayList dskh = new ArrayList();
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("1. Nhap danh sach hoa don khach hang");
                Console.WriteLine("2. Xuat danh sach hoa don khach hang");
                Console.WriteLine("3. Tinh tong so luong dien tieu thu cho tung loai khach hang");
                Console.WriteLine("4. Tinh trung binh thanh tien cua khach hang nuoc ngoai");
                Console.WriteLine("5. Xuat hoa don trong thang 09 nam 2020");
                Console.WriteLine("0. Thoat");
                Console.Write("Lua chon: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        NhapDanhSachHoaDon();
                        break;
                    case 2:
                        XuatDanhSachHoaDon();
                        break;
                    case 3:
                        TinhTongSoLuongDienTieuThu();
                        break;
                    case 4:
                        TinhTrungBinhThanhTienKHNuocNgoai();
                        break;
                    case 5:
                        XuatHoaDonThang();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
            } while (choice != 0);
        }

        private static void XuatHoaDonThang()
        {
            foreach (KhachHang k in dskh)
            {
                if (k.NgayHoaDon.Month == 9 && k.NgayHoaDon.Year == 2020)
                {
                    k.Xuat();
                }
            }
        }

        private static void TinhTrungBinhThanhTienKHNuocNgoai()
        {
            double tongtienNN = 0;
            int countKHNN = 0;
            foreach (KhachHang k in dskh)
            {
                if (k is KHNN)
                {
                    tongtienNN += k.ThanhTien;
                    countKHNN++;
                }
            }
            double tbtienNN = countKHNN > 0 ? tongtienNN / countKHNN : 0;
            Console.WriteLine($"Trung binh thanh tien cua khach hang nuoc ngoai: {tbtienNN}");
        }

        private static void TinhTongSoLuongDienTieuThu()
        {
            int tongVN = 0;
            int tongNN = 0;
            foreach (KhachHang k in dskh)
            {
                if (k is KHVN)
                {
                    tongVN += k.SoLuong;
                }
                else if (k is KHNN)
                {
                    tongNN += k.SoLuong;
                }
            }
            Console.WriteLine($"Tong so luong dien tieu thu cua khach hang Viet Nam: {tongVN}");
            Console.WriteLine($"Tong so luong dien tieu thu cua khach hang Nuoc Ngoai: {tongNN}");
        }

        private static void XuatDanhSachHoaDon()
        {
            foreach (KhachHang k in dskh)
            {
                k.Xuat();
            }
        }

        private static void NhapDanhSachHoaDon()
        {
            Console.WriteLine("1. Khach hang Viet Nam");
            Console.WriteLine("2. Khach hang Nuoc Ngoai");
            Console.Write("Lua chon: ");
            int loaiKH = int.Parse(Console.ReadLine());
            KhachHang kh;
            if (loaiKH == 1)
            {
                kh = new KHVN();
            }
            else
            {
                kh = new KHNN();
            }
            kh.Nhap();
            dskh.Add(kh);
        }
    }
}
