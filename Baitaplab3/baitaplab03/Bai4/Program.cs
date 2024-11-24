using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static int songaunhien;
        static bool run = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Nhan Enter de ket thuc.");
            Thread t1 = new Thread(SoNgauNhien);
            Thread t2 = new Thread(BinhPhuong);

            t1.Start();
            t2.Start();
            Console.ReadLine();
            run = false;

            t1.Join();
            t2.Join();
            Console.WriteLine("Chuong trinh ket thuc.");
        }

        private static void BinhPhuong()
        {
            while (run)
            {
                int binhphuong = songaunhien * songaunhien;
                Console.WriteLine($"Luong 2: Binh phuong cua {songaunhien} la {binhphuong}");
                Thread.Sleep(100);
            }
        }

        private static void SoNgauNhien()
        {
            Random random = new Random();
            while (run)
            {
                songaunhien = random.Next(1, 21);
                Console.WriteLine($"Luong 1: So ngau nhien duoc tao: {songaunhien}");
                Thread.Sleep(2000);
            }
        }
    }
}
