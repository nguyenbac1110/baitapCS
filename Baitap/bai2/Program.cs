using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    
    public class Program
    {
        public static ArrayList danhSach;
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Chon chuc nang :");
                Console.WriteLine("1. Tao danh sach hoc sinh");
                Console.WriteLine("2. Sua thong tin cua mot hoc sinh");
                Console.WriteLine("3. Xoa thong tin ve mot hoc sinh ra khoi danh sach");
                Console.WriteLine("4. Dua ra nhung hoc sinh co que quan Nam Dinh");
                Console.WriteLine("5. Dua ra nhung hoc sinh co diem tong ket lon nhat");
                Console.WriteLine("6. Thoat chuong trinh");
                 
                int chucNang = int.Parse(Console.ReadLine());

                switch (chucNang)
                {
                    case 1:
                        TaoDanhSachHocSinh();
                        break;
                    case 2:
                        SuaThongTinHocSinh();
                        break;
                    case 3:
                        XoaThongTinHocSinh();
                        break;
                    case 4:
                        DuaRaHocSinhNamDinh();
                        break;
                    case 5:
                        DuaRaHocSinhDiemTongKetLonNhat();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            }
        
    }

        static void DuaRaHocSinhDiemTongKetLonNhat()
        {
            double maxDiem = 0;
            foreach (SinhVien sv in danhSach)
            {
                if (sv.DiemTongKet > maxDiem)
                {
                    maxDiem = sv.DiemTongKet;
                }
            }

            Console.WriteLine("Nhung hoc sinh co diem tong ket lon nhat:");
            foreach (SinhVien sv in danhSach)
            {
                if (sv.DiemTongKet == maxDiem)
                {
                    sv.Xuat();
                }
            }
        }

        static void DuaRaHocSinhNamDinh()
        {
            bool found = false;
            foreach (SinhVien sv in danhSach)
            {
                if (sv.QueQuan.ToLower() == "nam dinh")
                {
                    sv.Xuat();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Khong co hoc sinh nao co que quan nam dinh!");
            }
        }

        static void XoaThongTinHocSinh()
        {
            Console.Write("Nhap ho ten hoc sinh muon xoa: ");
            string hoTen = Console.ReadLine();
            
            int index = -1;
            for (int i = 0; i < danhSach.Count; i++)
            {
                SinhVien temp = (SinhVien)danhSach[i];
                if (temp.HoTen.ToLower() == hoTen.ToLower())
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                danhSach.Remove(index);
                Console.WriteLine("Da xoa hoc sinh khoi danh sach.");
            }
            else
            {
                Console.WriteLine("Hoc sinh do khong co trong danh sach!");
            }
        }

        static void SuaThongTinHocSinh()
        {
            Console.Write("Nhap ho ten hoc sinh muon sua: ");
            string hoTen = Console.ReadLine();
            SinhVien sv = null;
            for (int i = 0; i < danhSach.Count; i++)
            {
                SinhVien temp = (SinhVien)danhSach[i];
                if (temp.HoTen.ToLower() == hoTen.ToLower())
                {
                    sv = temp;
                    break;
                }
            }
            if (sv != null)
            {
                Console.WriteLine("Nhap thong tin moi:");
                sv.Nhap();
            }
            else
            {
                Console.WriteLine("Hoc sinh do khong co trong danh sach!");
            }
        }

        static void TaoDanhSachHocSinh()
            {
            Console.Write("Nhap so luong hoc sinh: ");
            int soLuong = int.Parse(Console.ReadLine());
            danhSach = new ArrayList();
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhap thong tin hoc sinh thu {i + 1}:");
                SinhVien sv = new SinhVien();
                sv.Nhap();
                danhSach.Add(sv);
            }
        }
    }
}
