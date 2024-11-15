
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor_Or_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor D1 = new Doctor("dr. Rony", "Haddi", 550);

            Console.WriteLine("Befor obj refernce D1");
            D1.showDetails();


            // reference------------------------
            Doctor D2 = new Doctor(ref D1);
            Console.WriteLine("Refernce form D1 now D2 show");
            D2.showDetails();


            Console.WriteLine("now change value D2");
            D2 = new Doctor("dr. Jony", "Haddi and Buk", 800);
            D2.showDetails();


            Console.WriteLine("");
            Console.WriteLine("Now if we see D1 Values");
            D1.showDetails();




            Console.ReadKey();
        }
    }
}