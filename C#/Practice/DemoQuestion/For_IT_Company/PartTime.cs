using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_IT_Company
{
    internal class PartTime:Employee
    {
        private double commission {  get; set; }

        public PartTime(string id, string name, double salary, MidDate joiningDate, double commission) :base(id,name,salary,joiningDate)
        {
            this.commission = commission;
        }

        public override void GrossIncome()
        {
            double totalIncome = salary+commission;

            Console.WriteLine("-Total salary of monthly with commission-");
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
