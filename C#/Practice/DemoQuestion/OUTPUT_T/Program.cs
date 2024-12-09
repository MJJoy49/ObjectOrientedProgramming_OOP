using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTPUT_T
{
    class MyClass
    {
        public int Value;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.Value = 10;
            MyClass obj2 = obj1; // Copying the reference of 'obj1' to 'obj2'
            obj2.Value = 20; // Changing 'obj2.Value' affects 'obj1.Value'

            Console.WriteLine(obj1.Value); // Outputs: 20
            Console.WriteLine(obj2.Value); // Outputs: 20
        }
    }

}
