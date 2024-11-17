using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismOverloading
{
    internal class Calculator
    {

        
        public int sum (int x, int y)
        {
            return x + y;
        }


        //this is run time Overloading
        public double sum(double x, double y)
        {
            return x + y;
        }

        //this is run time Overloading
        public int sum(int x, int y,int z)
        {
            return x + y + z;
        }
            
           
            
    }
}
