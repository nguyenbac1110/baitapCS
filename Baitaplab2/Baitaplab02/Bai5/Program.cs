using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot xau ky tu: ");
            string str = Console.ReadLine();
            Console.WriteLine("Xau ky tu vua nhap: " + str);


            int Countthuong = 0;
            int Counthoa = 0;
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    Countthuong++;
                }
                else if (char.IsUpper(c))
                {
                    Counthoa++;
                }
            }
            Console.WriteLine($"So chu thuong: {Countthuong}");
            Console.WriteLine($"So chu hoa: {Counthoa}");

            string[] tu = str.Split(' ');
            int sotu = tu.Length;
            Console.WriteLine($"So tu: {sotu}");

            int songuyenam = 0;
            int sophuam = 0;
            foreach (char kyTu in str.ToLower())
            {
                if ("aeiou".Contains(kyTu))
                {
                    songuyenam++;
                }
                else if (char.IsLetter(kyTu))
                {
                    sophuam++;
                }
            }
            Console.Write("So nguyen am: ");
            Console.WriteLine(songuyenam);
            Console.Write("So phu am: ");
            Console.WriteLine(sophuam);

            Console.Write("Nhap vao mot xau con: ");
            string strcon = Console.ReadLine();
            int solanxh = 0;
            int vitri = str.IndexOf(strcon);
            while (vitri != -1)
            {
                solanxh++;
                vitri = str.IndexOf(strcon, vitri + 1);
            }
            Console.Write("So lan xuat hien cua xau con: ");
            Console.WriteLine(solanxh);

        }
    }
}
