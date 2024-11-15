using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Teacher:Person
    {
        public string subject;
        public string dept;
        public double salary;


        public Teacher()
        {
            Console.WriteLine("I am Teacher Class.");
        }

        public void ShowTeacherDetails()
        {
            Console.WriteLine("-------Teacher Details------");
            Console.WriteLine($"Name       : {this.name}");
            Console.WriteLine($"Age        : {this.age}");
            Console.WriteLine($"Religion   : {this.religion}");
            Console.WriteLine($"Subject    : {this.subject}");
            Console.WriteLine($"Department : {this.dept}");
            Console.WriteLine($"Selary : {this.salary}");
            Console.WriteLine("----------------------------");
        }
    }
}
