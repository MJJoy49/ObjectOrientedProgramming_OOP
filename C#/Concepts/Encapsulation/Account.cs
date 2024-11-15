using System;

namespace Encapsulation
{
    internal class Account
    {
        public string accountId;
        public string userName;

        // Encapsulation can do data hiding
        //this call data hiding cz this 2 properties are private.
        private string password;
        private double balance = 10000;


        // Default Constructor
        public Account()
        {
            //costructor-> 
            // same name as class name
            // doesn't have return type
            // default costructor call automatically whan create a object
            // parmeterized also a constructor it's call parameterized constructor ,
            // And it can be one or more 

            Console.WriteLine("hi i am default constructor");
        }


        //parameterized Constructor
        public Account(string accountId, string userName, string password)
        {
            this.accountId = accountId;
            this.userName = userName;
            setPassword(password);

        }


        public void setPassword(string pass)
        {
            this.password = pass;
        }


        


        public void showBalance()
        {
            Console.WriteLine($"Your Account Id: {this.accountId}");
            Console.WriteLine($"Your User Name: {this.userName}");
            Console.Write("Enter your password: ");
            string password= Console.ReadLine();

            if ( password == this.password  )
            {
                Console.WriteLine($"Your current balance is {this.balance}");
            }
            else{

                Console.WriteLine("invalid password!");
            }
        }


    }
}