using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    internal class Student:Person
    {
        private string name;
        private int roll;


        // there static cz For the students objs
        // of that school, the name of that school name is always
        // Same ,
        // thats why We can declare as a static variable 
        public static  string schoolName="MSC";



        //static constructor / default constructor

        public Student() {
            Console.WriteLine("I am default constructor of Student class");

        }

        static Student()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("I am STATIC constructor of Student class");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");

        }




        public void setName(string name)
        { 
            this.name = name; 
        }
        public string getName()
        {
            return this.name;
        }

        public void setRoll(int roll)
        {
            this.roll = roll;
        }

        public int getRoll(int roll) 
        {
            return roll;
        }


        public static void amni()
        {
            Console.WriteLine("i am static funtion");
        }


        public void studentDetails()
        {
            Console.WriteLine($"----------------------------");
            Console.WriteLine($"School Name: {schoolName}");
            Console.WriteLine($"Student Name: {this.name}");
            Console.WriteLine($"Student Roll: {this.roll}");
            Console.WriteLine($"----------------------------");

        }

    }
}
