using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            //When properties & member functions of
            //base/parent class
            //ar passed on to
            // derived/child class

            //Access Modifiers:
            //-------------------
            //public members are accessible in derived classes.
            //protected members are accessible only within the base class and derived classes.
            //private members are not inherited.


            Teacher T1 = new Teacher();
            T1.name = "Lizu";
            T1.dept = "CSE";
            T1.age = 22;
            T1.subject = "C#";
            T1.religion = "Islam";
            T1.salary = 40000;
            T1.ShowTeacherDetails();

            Console.WriteLine("");

            Student S1 = new Student();

            S1.name = "jOY";
            S1.age = 22;
            S1.religion = "Islam";
            S1.id = "S12345";
            S1.dept = "CSE";
            S1.cgpa = 3.85;
            S1.showStudentDetails();


            Console.WriteLine("");


            StudentToTeacher st = new StudentToTeacher();

            // Assign properties from the Person class
            st.name = "Rony";
            st.age = 23;
            st.religion = "Islam";

            // Assign properties from the Teacher class
            st.subject = "C#";
            st.dept = "CSE";
            st.salary = 50000;

            // Assign properties from the Student class
            st.id = "S12345";
            st.cgpa = 3.85;

            // Show combined details
            st.ShowDetailsOfST();

            Console.ReadKey();
        }
    }
}
