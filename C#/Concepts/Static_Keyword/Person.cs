using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    internal class Person
    {
        public Person()
        {
            Console.WriteLine("I am default constructor of Person class");

        }

        static Person()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("I am STATIC constructor of Person class");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");

        }


    }
}
