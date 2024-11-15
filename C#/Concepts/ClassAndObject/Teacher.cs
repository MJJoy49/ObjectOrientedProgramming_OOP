using System;

namespace ClassAndObject
{
    internal class Teacher
    {

        //properties / attribute
        public string name;
        public string subject;
        public string dept;
        public double salary;



        //methods / member functions
        public void changeDept(string newDept)
        {
            dept = newDept;
        }



        //methods 2 / member functions 2
        public void displayInfo()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Subject: {this.subject}");
            Console.WriteLine($"Department: {this.dept}");
            Console.WriteLine($"Salary: {this.salary}");
            Console.WriteLine("---------------------");
        }
    }
}