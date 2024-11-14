using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task3
{
    internal class Bank
    {
        private string name;
        private int acconuntNumber;
        private double balance;

        public Bank()
        {

        }

        public Bank(string name, int acconuntNumber, double balance)
        {
            this.name = name;
            this.acconuntNumber = acconuntNumber;
            this.balance = balance;
        }


        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAcconuntNumber(int acconuntNumber)
        {
            this.acconuntNumber = acconuntNumber;
        }

        public int GetId()
        {
            return acconuntNumber;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public double GetBalance()
        {
            return balance;
        }



        public void bankDetails()
        {
            Console.WriteLine($"-----------Bank Details------------");
            Console.WriteLine($"Name is  {this.name}");
            Console.WriteLine($"AcconuntNumber is {this.acconuntNumber}");
            Console.WriteLine($"Balance has {this.balance}");
            Console.WriteLine($" ");
        }

    }
}
