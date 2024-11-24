using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());

            double[,] ma = new double[n, m];

            Console.WriteLine("Nhap cac phan tu cua ma tran:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Phan tu [{i}, {j}]: ");
                    ma[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ma tran:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{ma[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            double ammin = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (ma[i, j] < 0)
                    {
                        ammin = ma[i, j];
                    }
                }
            }
            Console.WriteLine($"So am nho nhat cua ma tran: {ammin}");

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int k = i + 1; k < n; k++)
                    {
                        if (ma[i, j] > ma[k, j])
                        {
                            double temp = ma[i, j];
                            ma[i, j] = ma[k, j];
                            ma[k, j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Ma tran sau khi sap xep:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{ma[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            Console.Write("Nhap so cot can xoa: ");
            int km = int.Parse(Console.ReadLine());
            if (km >= 0 && km < m)
            {
                double[,] newma = new double[n, m - 1];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < km; j++)
                    {
                        newma[i, j] = ma[i, j];
                    }
                    for (int j = km; j < m - 1; j++)
                    {
                        newma[i, j] = ma[i, j + 1];
                    }
                }
                ma = newma;
                m--;
            }
            Console.WriteLine("Ma tran sau khi xoa cot:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{ma[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            double sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (ma[i, j] % 2 == 0)
                    {
                        sum += ma[i, j];
                        count++;
                    }
                }
            }
            double tongchan = count == 0 ? 0 : sum / count;
            Console.WriteLine($"Trung trung binh cong cac phan tu co gia tri chan: {tongchan}");
        }
    
    }
}
