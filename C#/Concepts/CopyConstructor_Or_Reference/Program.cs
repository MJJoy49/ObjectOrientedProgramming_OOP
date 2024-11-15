
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

            //Doctor D1 = new Doctor();
            //D1.name = "dr. Rony";
            //D1.specialty = "Haddi";
            //D1.visitFree = 500;

            Console.WriteLine("Befor obj refernce D1");
            D1.showDetails();


            // reference------------------------
            Doctor D2 = D1;
            Console.WriteLine("Refernce form D1 now D2 show");
            D2.showDetails();


            Console.WriteLine("now change value D2");
            D2 = new Doctor("dr. Jony", "Haddi and Buk", 800);

            //D2.name = "dr. Jony";
            //D2.specialty = "Haddi and Buk";
            //D2.visitFree = 800;

            D2.showDetails();


            Console.WriteLine("");
            Console.WriteLine("Now if we see D1 Values");
            D1.showDetails();




            Console.ReadKey();
        }
    }
}