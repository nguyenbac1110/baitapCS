using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();

            Console.Write("Nhap so luong hoc sinh: ");
            int numStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numStudents; i++)
            {
                Student student = new Student();
                student.Input();
                studentList.Add(student);
            }

            Console.WriteLine("Danh sach hoc sinh:");
            foreach (Student student in studentList)
            {
                student.Display();
                Console.WriteLine();
            }

            Console.WriteLine("Hoc sinh voi ten 'Nam':");
            foreach (Student student in studentList)
            {
                if (student.Name == "Nam")
                {
                    student.Display();
                    break;
                }
            }
        }
        }
}
