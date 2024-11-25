using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task5
{
    internal class Model:Phone
    {
        private int stock { get; set; }
        private double price { get; set; }


        public Model(int stock, double price, string id, string ManufacturerType, string ReleaseDate) : base(id, ManufacturerType, ReleaseDate)
        {
            this.stock = stock;
            this.price = price;
        }


        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"ReleaseDate      : {ReleaseDate}");
            Console.WriteLine($"Avalable in stock: {stock}");
            Console.WriteLine($"Price            : {price}");
        }


        public double TotalBill(int quantity)
        {
            double totalBill = price * quantity;
            double discount = 0;
            double vat = 0;

            if (price > 10000)
            {
                discount = totalBill * 0.05;
            }

            if(ManufacturerType== "foreigner")
            {
                vat = totalBill * 0.05;
            }

            totalBill = totalBill - discount + vat;
            

            Console.WriteLine($"Total bill for {quantity} units: {totalBill}");
            return totalBill;
        }
    }
}
