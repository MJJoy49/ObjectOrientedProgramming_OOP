using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator1 = new Calculator();


            //its call polymorphism-> overloading same name function but  Different parameter
            Console.WriteLine(calculator1.sum(12,23));
            Console.WriteLine(calculator1.sum(12.44, 23.77));
            Console.WriteLine(calculator1.sum(50, 203,233));




            Console.ReadKey();
            
        }
    }
}
