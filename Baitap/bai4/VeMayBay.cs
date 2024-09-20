using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class VeMayBay
    {
        public string TenChuyen { get; set; }
        public DateTime NgayBay { get; set; }
        public double GiaVe { get; set; }

        public VeMayBay() { }

        public VeMayBay(string tenChuyen, DateTime ngayBay, double giaVe)
        {
            TenChuyen = tenChuyen;
            NgayBay = ngayBay;
            GiaVe = giaVe;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten chuyen: ");
            TenChuyen = Console.ReadLine();
            Console.Write("Nhap ngay bay (yyyy-mm-dd): ");
            NgayBay = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap gia ve: ");
            GiaVe = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Ten chuyen: {TenChuyen}, Ngay bay: {NgayBay.ToShortDateString()}, Gia ve: {GiaVe}");
        }

        public double GetGiaVe()
        {
            return GiaVe;
        }
    }
}
