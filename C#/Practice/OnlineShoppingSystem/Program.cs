using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace OnlineShoppingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //List<string> name= new List<string>();


            //Console.Write("how many list you want:");
            //int n=int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++) 
            //{
            //    Console.Write($"Enter your list num {i+1}:");
            //    name.Add(Console.ReadLine());
            //}


            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}



            

        }
    }
}









//Task: Online Shopping System
//Design and implement an Online Shopping System
//where you can use the entire OOP concept effectively.
//The system will include users, products, orders, and payment mechanisms.

//Requirements:

//Encapsulation:

//Manage private data like user credentials or payment details using properties.
//Use methods to validate and securely process data.

//Inheritance:

//Create a base User class with derived classes for Customer and Admin.
//Create a base Product class with specific types like Electronics, Clothing, and Groceries.

//Polymorphism:

//Override methods for displaying products based on the product type.
//Implement payment options like CreditCard and PayPal using method overriding.


//Abstraction:

//Use an abstract class or an interface for the Payment system to define shared behavior like ProcessPayment.
//Your Task Instructions:


//Classes:

//User: Base class with attributes like Username and Password.
//Admin: Can add/remove products.
//Customer: Can browse, add to cart, and place orders.
//Product: Base class for products with Name, Price, and Stock.
//Derived classes like Electronics, Clothing, and Groceries.
//Order: Manages the cart and calculates the total price.
//Payment: Abstract class or interface for CreditCard and PayPal.
//Features:

//Admin Features:
//Add or remove products.
//Update stock or price.
//Customer Features:
//Browse products.
//Add products to a cart.
//Checkout and make payments.
//Payment Options:
//Implement payment methods like CreditCard and PayPal with method overriding.
//Example Flow:
//The admin adds products to the store.
//A customer browses the products.
//The customer adds products to their cart.
//The customer checks out, chooses a payment method, and completes the purchase.


//OOP Concepts Usage:
//Encapsulation: Keep product details and user data private, expose necessary details using properties.
//Inheritance: Use a hierarchical structure for users and products.
//Polymorphism: Use overridden methods for specific product displays and payment processing.
//Abstraction: Use interfaces or abstract classes for flexible payment methods.
//Start with this high - level idea and implement it step by step.Let me know
//if you'd like more guidance or a breakdown of the tasks!