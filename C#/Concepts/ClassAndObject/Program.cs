using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Teacher class
            Teacher t1Obj = new Teacher(); 
            
            // Assign values to the Teacher object's properties
            t1Obj.name = "Mr. Smith"; 
            t1Obj.subject = "Mathematics"; 
            t1Obj.dept = "Math Department"; 
            t1Obj.salary = 50000;


            //mathod call.
            t1Obj.displayInfo();

            //change dept with mathod
            t1Obj.changeDept("CSE");

            //again display mathod call
            t1Obj.displayInfo();




            //this way we can create more object for more teacher;




           Console.ReadKey();   
        }
    }
}
