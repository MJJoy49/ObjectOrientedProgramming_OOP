using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student:Person
    {
        public string id;
        public double cgpa;
        public string dept;


        public Student()
        {
            Console.WriteLine("I am a student class");
        }


        public void showStudentDetails()
        {
            Console.WriteLine("-------Student Details------");
            Console.WriteLine($"Name       : {this.name}");
            Console.WriteLine($"Age        : {this.age}");
            Console.WriteLine($"Religion   : {this.religion}");
            Console.WriteLine($"Id         : {this.id}");
            Console.WriteLine($"CGPA       : {this.cgpa}");
            Console.WriteLine($"Department : {this.dept}");
            Console.WriteLine("----------------------------");
        }
    }
}
