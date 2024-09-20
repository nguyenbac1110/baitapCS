using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class PhanSo
    {
        public int tuso { get; set; } 
        public int mauso { get; set; }
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }

      
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }

        
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauso = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine(tuso + "/" + mauso);
        }

        public PhanSo Cong(PhanSo ps)
        {
            PhanSo ps_ = new PhanSo();
            ps_.tuso = this.tuso * ps.mauso + this.mauso * ps.tuso;
            ps_.mauso = this.mauso * ps.mauso;
            return ps_;
        }
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo ps_ = new PhanSo();
            ps_.tuso = this.tuso * ps.mauso - this.mauso * ps.tuso;
            ps_.mauso = this.mauso * ps.mauso;
            return ps_;
        }

        
        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo ps_ = new PhanSo();
            ps_.tuso = this.tuso * ps.tuso;
            ps_.mauso = this.mauso * ps.mauso;
            return ps_;
        }

       
        public PhanSo Chia(PhanSo ps)
        {
            PhanSo ps_ = new PhanSo();
            ps_.tuso = this.tuso * ps.mauso;
            ps_.mauso = this.mauso * ps.tuso;
            return ps_;
        }

        
        public void TinhTong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq = ps1.Cong(ps2);
            kq.Xuat();
        }

        
        public void TinhHieu(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq = ps1.Tru(ps2);
            kq.Xuat();
        }

       
        public void TinhTich(PhanSo ps1, PhanSo ps2)
        {
            PhanSo result = ps1.Nhan(ps2);
            result.Xuat();
        }

        
        public void TinhThuong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo result = ps1.Chia(ps2);
            result.Xuat();
        }
    }
}
