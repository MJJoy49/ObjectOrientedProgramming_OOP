using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task4
{
    internal class AcademicBook:Book
    {
        private string publisher;
        private string type;


        


        public AcademicBook(string BookName, string id, int quantity, string publisher, string type) : base(BookName, id, quantity)
        {
            this.publisher = publisher;
            this.type = type;
        }



        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }
        public string getPublisher() { return this.publisher; }




        public void setType(string type)
        {
            this.type = type;
        }

        public string getType() { return this.type; }







        public void PrintAcademicBook()
        {
            Console.WriteLine("-------Academic Book Details--------");
            Console.WriteLine($"Book Name    : {base.BookName}");
            Console.WriteLine($"Book Id      : {base.id}");
            Console.WriteLine($"Book Quantity: {base.quantity}");
            Console.WriteLine($"Publisher    : {this.publisher}");
            Console.WriteLine($"Type         : {this.type}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
        }
    }
}
