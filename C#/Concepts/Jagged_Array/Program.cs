using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Suppose you are a carpenter.You create wardrobes of different sizes according to the user.
            //Where the user specifies how many drawers his wardrobe should have.
            //And in each drawer he can put any item he wants.
            //Now you create it with Jagged_array



            Console.WriteLine("**********Welcome to Carpentry shop************");
            Console.WriteLine("");


            Console.Write("How many drawers you have need for your wardrobe: ");
            int drawersNum = int.Parse(Console.ReadLine());
            string[][] wardrobe = new string[drawersNum][];


            Console.WriteLine("Your wardrobe is ready!.....");
            Console.WriteLine("");

            Console.WriteLine($"How many items do you want to keep in ->");
            for (int i = 0; i < drawersNum; i++)
            {
                Console.Write($"drawer number {i + 1}: ");
                int iteamNum = int.Parse(Console.ReadLine());

                wardrobe[i] = new string[iteamNum];

                for (int j = 0; j < iteamNum; j++)
                {
                    Console.Write($"Enter your iteam{j + 1} name: ");
                    string itemName = Console.ReadLine();

                    wardrobe[i][j] = itemName;
                }
                Console.WriteLine("");
            }

            Console.WriteLine($"Your wardrobe is full!.........");
            Console.WriteLine("");
            Console.WriteLine("-------------Wardrobe datails-------------");


            for (int i = 0; i < drawersNum; i++)
            {
                Console.WriteLine($"There are items in drawer number {i + 1}");
                Console.WriteLine("");

                for (int j = 0; j < wardrobe[i].Length; j++)
                {
                    Console.Write($"{wardrobe[i][j]} | ");
                }
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("");
            }










            Console.ReadKey();

        }
    }
}
