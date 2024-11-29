using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_IT_Company
{
    internal class FullTime:Employee
    {
        private double bonus {  get; set; }


        public FullTime(string id, string name, double salary, MidDate joiningDate, double bonus):base(id,name, salary,joiningDate)
        {
            this.bonus = bonus;
        }



        public override void GrossIncome()
        {
            double totalIncome=(salary*12)+bonus+bonus;

            Console.WriteLine("-Total salary of 12 month's with 2 time bonus-");
            Console.WriteLine($"==> {totalIncome} tk");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("------Empolyee Info--------");
            Console.WriteLine($"Id           : {id}");
            Console.WriteLine($"Name         : {name}");
            Console.WriteLine($"Salary       : {salary}");
            Console.WriteLine($"Joining Date : {joiningDate.GetFormattedDate()}");
            Console.WriteLine("");
        }
    }
}
