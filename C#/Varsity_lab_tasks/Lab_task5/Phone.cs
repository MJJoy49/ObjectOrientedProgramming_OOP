using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task5
{
    internal class Phone
    {

        static Phone()
        {
            Console.WriteLine(" ------------------------------------------ ");
            Console.WriteLine("|                                          |");
            Console.WriteLine("|           WELCOME TO PHONE SHOP          |");
            Console.WriteLine("|                                          |");
            Console.WriteLine(" ------------------------------------------ ");

        }

        public Phone(string id, string manufacturerType, string releaseDate)
        {
            this.id = id;
            this.ManufacturerType = manufacturerType;
            this.ReleaseDate = releaseDate;
        }

        public string id { get; set; }
        public string ManufacturerType { get; set; }
        public string ReleaseDate { get; set; }


        public virtual void ShowDetails()
        {
            Console.WriteLine($"-----------Phone Details------------");
            Console.WriteLine($"Phone ID         : {id}");
            Console.WriteLine($"ManufacturerType : {ManufacturerType}");
            Console.WriteLine($"ReleaseDate      : {ReleaseDate}");
        }
    }
}
