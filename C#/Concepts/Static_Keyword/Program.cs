using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------
            //static keyword
            // static keyword used to share the same variable or mathod of a given class.

            // we can do static
            //-Properties
            //-function
            //-blocks 
            //-nested classes
            //------------------------------------------------


            Student s1 = new Student();

            s1.setName("Jony");
            s1.setRoll(34);

            s1.studentDetails();

            Student s2 = new Student();

            s2.setName("Jony");
            s2.setRoll(34);

            s2.studentDetails();


            Student s3 = new Student();

            s3.setName("Jony");
            s3.setRoll(34);

            s3.studentDetails();


            // Changing the static `schoolName` using the class name
            Student.schoolName = "New School Name";


            Console.WriteLine("after changing static `schoolName` ");
            s1.studentDetails();
            s2.studentDetails();
            s3.studentDetails();
            Student.amni();



        }
    }
}


//output---------------------------------------------------------

//------------------------------------------

//I am STATIC constructor of Student class

//------------------------------------------
//------------------------------------------

//I am STATIC constructor of Person class

//------------------------------------------
//I am default constructor of Person class
//I am default constructor of Student class
//----------------------------
//School Name: MSC
//Student Name: Jony
//Student Roll: 34
//----------------------------
//I am default constructor of Person class
//I am default constructor of Student class
//----------------------------
//School Name: MSC
//Student Name: Jony
//Student Roll: 34
//----------------------------
//I am default constructor of Person class
//I am default constructor of Student class
//----------------------------
//School Name: MSC
//Student Name: Jony
//Student Roll: 34
//----------------------------
//after changing static `schoolName`
//----------------------------
//School Name: New School Name
//Student Name: Jony
//Student Roll: 34
//----------------------------
//----------------------------
//School Name: New School Name
//Student Name: Jony
//Student Roll: 34
//----------------------------
//----------------------------
//School Name: New School Name
//Student Name: Jony
//Student Roll: 34
//----------------------------
//i am static funtion

