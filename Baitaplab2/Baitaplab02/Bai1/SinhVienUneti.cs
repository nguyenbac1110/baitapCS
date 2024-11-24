using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public abstract class SinhVienUneti
    {
        public string HoTen { get; set; }
        public string Nganh { get; set; }

        public abstract double GetDiem();

        public string GetXepLoaiHL()
        {
            double diem = GetDiem();
            if (diem >= 9.0)
                return "Xuat sac";
            else if (diem >= 8.0)
                return "Gioi";
            else if (diem >= 7.0)
                return "Kha";
            else if (diem >= 6.0)
                return "Trung binh";
            else
                return "Yeu";
        }

       
        public void XuatThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nganh: {Nganh}");
            Console.WriteLine($"Điem: {GetDiem():F2}");
            Console.WriteLine($"Xep loai hoc luc: {GetXepLoaiHL()}");
        }
    }
}
