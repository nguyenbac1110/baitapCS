using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Student : Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NativePlace { get; set; }
        public string Id { get; set; }

        public Student()
        {
        }

        public void Input()
        {
            Console.Write("name: ");
            Name = Console.ReadLine();
            Console.Write("age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("native place: ");
            NativePlace = Console.ReadLine();
            Console.Write("ID: ");
            Id = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Native Place: {NativePlace}");
            Console.WriteLine($"ID: {Id}");
        }
    }
}
