using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////using ForEach--------
            Console.WriteLine("----------using ForEach print----------");
            string[] Deps = { "CSE", "CS", "EEE", "BBA" };

            Console.WriteLine("There some department Name:");

            foreach (string Dep in Deps)
            {
                Console.WriteLine(Dep);
            }



            //calculation
            Console.WriteLine("----------calculation----------");
            Console.Write("Enter the 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            double div = num1 / num2;
            double mod = num1 % num2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Sub: {sub}");
            Console.WriteLine($"Mul: {mul}");
            Console.WriteLine($"Div: {div}");
            Console.WriteLine($"Mod: {mod}");



            //print area of a circle 
            Console.WriteLine("----------print area of a circle----------");
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine($"The area of the circle is: {area}");




            //write a program compare two number 
            Console.WriteLine("----------compare two number----------");
            Console.WriteLine("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{firstNumber} is less than {secondNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} is equal to {secondNumber}");
            }










            //print even number from 1 to n
            Console.WriteLine("----------even number from 1 to n----------");
            Console.Write("Enter your nth number:");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine($"The even number between 1 to {n}");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i},");

                }

            }







            //take input for jagged array and prints the output
            Console.WriteLine("");
            Console.WriteLine("----------jagged array and prints----------");
            int[][] jaggedArray = new int[3][];


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Enter the number of elements for row {i + 1}: ");
                int size = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[size];

                Console.WriteLine($"Enter {size} elements for row {i + 1}: ");
                for (int j = 0; j < size; j++)
                {
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("The jagged array is: ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }







            //sum of add even between 1 to 100
            Console.WriteLine("----------sum of add even between 1 to 100----------");
            int s = 0;


            Console.WriteLine($"Even numbers between 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}+");
                    sum = sum + i;
                }

            }
            Console.WriteLine(' ');
            Console.WriteLine($"The sum of evens numbers={s}");








            //XOXOXOXOX Arry
            Console.WriteLine("----------XOXOXOXOX pattan----------");
            int active = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (active == 1)
                    {
                        Console.Write($"X ");
                        active = 0;
                    }
                    else
                    {
                        Console.Write($"O ");
                        active = 1;
                    }

                }

                Console.WriteLine();
            }
            


        }
    }
}
