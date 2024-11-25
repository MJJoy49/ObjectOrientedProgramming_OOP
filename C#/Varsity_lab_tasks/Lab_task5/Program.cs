using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //phone -> Id manofachertype(foraner , deshi) date(releasd) (set get) vartial show 
            // model -> stock ,price, set get ,override show mathod ,, void totalBill(if(price > 10,000)(discount 5%) else(foraner==manofachertype){+vat5%})
            // 3input (user as shopkepper) show for clint -> customar choice how many need buy  public string ManufacturerType { get; set; } // foreigner or deshi


            Model m1 = new Model
            (
                50,
                12000,
                "004",
                "foreigner",
                "10-10-2020"
            );


            Model m2 = new Model
            (
                40,
                9000,
                "009",
                "foreigner",
                "09-11-2022"
            );

            Model m3 = new Model
            (
                30,
                8000,
                "007",
                "deshi",
                "09-11-2022"
            );


            m1.ShowDetails();
            m2.ShowDetails();
            m3.ShowDetails();


            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");

            Console.Write("How many type model you Buy: ");
            int n=int.Parse( Console.ReadLine() );
            if (n == 0)
            {
                Console.WriteLine("ok!");
            }
            else if (n >= 3)
            {
                 Console.WriteLine("invailid input");
                return;
            }






            double OverAllBill=0;
            for (int i = 1; i <= n; i++)
            { 
                Console.Write( $"Phone {i}-> Enter your phone id number: " );
                string ID= Console.ReadLine() ;
                Console.Write($"Phone {i}-> quantity: ");
                int quan=int.Parse( Console.ReadLine() );

                if (m1.id == ID)

                {
                   OverAllBill=OverAllBill+ m1.TotalBill(quan);
                }

                else if (m2.id == ID)
                {
                    OverAllBill = OverAllBill + m2.TotalBill(quan);
                }

                else if (m3.id == ID)
                {
                    OverAllBill = OverAllBill + m3.TotalBill(quan);
                }
                else {
                    Console.WriteLine("invailt");
                    return ;
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }



            Console.WriteLine("");
            Console.WriteLine($"---------------Payment rec.-------------");
            Console.WriteLine($" So, your over All Bill is :{OverAllBill}");















            Console.ReadKey();


        }
    }
}
