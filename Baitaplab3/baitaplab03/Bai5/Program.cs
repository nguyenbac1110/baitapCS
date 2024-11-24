using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static ArrayList danhSachSV = new ArrayList();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("===== QUAN LY SINH VIEN =====");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Sua thong tin sinh vien");
                Console.WriteLine("3. Xoa sinh vien");
                Console.WriteLine("4. Hien thi so luong sinh vien");
                Console.WriteLine("5. Hien thi danh sach sinh vien theo lop");
                Console.WriteLine("6. Thoat");
                Console.Write("Chon chuc nang: ");

                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        SuaSinhVien();
                        break;
                    case 3:
                        XoaSinhVien();
                        break;
                    case 4:
                        HienThiSoLuong();
                        break;
                    case 5:
                        HienThiTheoLop();
                        break;
                    case 6:
                        Console.WriteLine("Thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Chuc nang khong hop le. Vui long chon lai.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void HienThiTheoLop()
        {
            Console.Write("Nhap lop hoc can hien thi: ");
            string lopHoc = Console.ReadLine();

            Console.WriteLine("Danh sach sinh vien lop {0}:", lopHoc);
            foreach (SinhVien sv in danhSachSV)
            {
                if (sv.LopHoc == lopHoc)
                {
                    sv.HienThiThongTin();
                }
            }
        }

        private static void HienThiSoLuong()
        {
            Console.WriteLine("So luong sinh vien: {0}", danhSachSV.Count);
           
        }

        private static void XoaSinhVien()
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string maSV = Console.ReadLine();
            int index = FindSV(maSV);

            if (index != -1)
            {
                danhSachSV.RemoveAt(index);
                Console.WriteLine("Xoa sinh vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co ma so {0}", maSV);
            }
        }

        private static void SuaSinhVien()
        {
            Console.Write("Nhap ma sinh vien can sua: ");
            string maSV = Console.ReadLine();
            int index = FindSV(maSV);

            if (index != -1)
            {
                danhSachSV[index] = new SinhVien();
                ((SinhVien)danhSachSV[index]).NhapThongTin();
                Console.WriteLine("Sua thong tin sinh vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co ma so {0}", maSV);
            }
        }

        static int FindSV(string maSV)
        {
            for (int i = 0; i < danhSachSV.Count; i++)
            {
                if (((SinhVien)danhSachSV[i]).MaSV == maSV)
                {
                    return i;
                }
            }
            return -1;
        }
        private static void ThemSinhVien()
        {
            while (true)
            {
                SinhVien sv = new SinhVien();
                sv.NhapThongTin();
                danhSachSV.Add(sv);
                Console.WriteLine("Them sinh vien thanh cong!");
                Console.Write("Ban co muon nhap tiep khong (Y/N)? ");
                string tiepTuc = Console.ReadLine();
                if (tiepTuc.ToUpper() != "Y")
                {
                    break; 
                }
            }
        }
    }
    }

