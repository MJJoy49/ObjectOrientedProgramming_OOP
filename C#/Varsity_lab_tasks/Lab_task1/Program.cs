using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //odd-even task
            Console.WriteLine("-------------odd-even----------");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }




            //leap-years----
            Console.WriteLine("-------------leap-years----------");
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }



            //Fibonacci series
            Console.WriteLine("-------------Fibonacci series----------");
            Console.Write("Enter the number for Fibonacci series : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int firstNum = 0, secondNum = 1, nextNum;
            Console.Write("Fibonacci Series: " + firstNum + " " + secondNum + " ");

            for (int i = 2; i < n; ++i)
            {
                nextNum = firstNum + secondNum;
                Console.Write(nextNum + " ");
                firstNum = secondNum;
                secondNum = nextNum;
            }
            Console.WriteLine();



            //PrintEvenNumber
            Console.WriteLine("-------------Print all EvenNumber----------");
            Console.Write("Enter End point: ");
            int l = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= l; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}+");
                }
            }




            Console.ReadKey();
        }
    }
}
