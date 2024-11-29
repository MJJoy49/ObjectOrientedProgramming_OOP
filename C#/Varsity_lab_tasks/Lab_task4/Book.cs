using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task4
{
    internal class Book
    {
        //book name, book Id, quantity, set get +print

        protected string BookName { get; set; }
        protected string id { get; set; }
        protected int quantity { get; set; }




        static Book()
        {
            Console.WriteLine(" ___________________________________________");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|          Welcome to book store            |");
            Console.WriteLine("|___________________________________________|");
            Console.WriteLine("");
        }


        public Book(string BookName, string id, int quantity)
        {
            this.BookName = BookName;
            this.id = id;
            this.quantity = quantity;
        }
        //public void setBookName(string BookName)
        //{
        //    this.BookName = BookName;
        //}
        //public string getBookName() { return this.BookName; }




        //public void setBookId(string id)
        //{
        //    this.id = id;
        //}

        //public string getBookId() { return this.id; }






        //public void setQuantity(int quantity)
        //{
        //    this.quantity = quantity;
        //}

        //public int getQuantity() { return this.quantity; }





        public void PrintBook()
        {
            Console.WriteLine($"-----------BOOK Details---------");
            Console.WriteLine($"Book Name    : {this.BookName}");
            Console.WriteLine($"Book Id      : {this.id}");
            Console.WriteLine($"Book Quantity: {this.quantity}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
        }

    }
}
