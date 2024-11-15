using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StudentToTeacher : Teacher
    {
        public string id;
        public double cgpa;

        public StudentToTeacher()
        {
            Console.WriteLine("This is the StudentToTeacher class.");
        }

        public void ShowDetailsOfST()
        {
            Console.WriteLine("-------Student to Teacher Details------");
            Console.WriteLine($"Name       : {this.name}");
            Console.WriteLine($"Age        : {this.age}");
            Console.WriteLine($"Religion   : {this.religion}");
            Console.WriteLine($"Subject    : {this.subject}");
            Console.WriteLine($"Department : {this.dept}");
            Console.WriteLine($"ID         : {this.id}");
            Console.WriteLine($"CGPA       : {this.cgpa}");
            Console.WriteLine($"Salary     : {this.salary}");
            Console.WriteLine("---------------------------------------");
        }


    }
}
