using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation is wrapping up 
            // of [data | member functions]
            // is a single unit called class



            // here in Account class used Encapsulation concept.
            Account ob1= new Account("203332","Joy01","24joy24");
            ob1.showBalance();



            Console.ReadKey();
        }
    }
}
