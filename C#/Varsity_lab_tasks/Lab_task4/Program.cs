using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            StoryBook sb1 = new StoryBook("BookA","24-2233",32,"person k","Story Book");
            AcademicBook ab1 = new AcademicBook("BookB", "24-10033", 50, "person k", "Acadamic Book");

            sb1.PrintStoryBook();
            ab1.PrintAcademicBook();







        }
    }
}
