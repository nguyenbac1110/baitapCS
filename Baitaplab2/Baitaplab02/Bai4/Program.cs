using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args) { 
            Console.Write("Nhap kich thuoc cua ma tran vuong: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] ma = new double[n, n];

            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    Console.Write($"Nhap phan tu - [{i}, {j}]: ");
                    ma[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("Ma tran:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(ma[i, j] + " ");
                }
                Console.WriteLine();
            }

            double tongcheophu = 0;
            for (int i = 0; i < n; i++)
            {
                tongcheophu += ma[i, n - i - 1];
            }
            Console.WriteLine($"Tong cac phan tu tren duong cheo phu: {tongcheophu}");

            double ammax = 0;
            for (int i = 0; i < n; i++)
            {
                if (ma[i, i] < 0 && ma[i, i] > ammax)
                {
                    ammax = ma[i, i];
                }
            }
            Console.WriteLine($"So am lon nhat tren duong cheo chinh: {ammax}");

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ma[i, j] % 3 == 0 && ma[i, j] % 5 == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"So phan tu chia het cho 3 và 5: {count}");
        }
    }
}
