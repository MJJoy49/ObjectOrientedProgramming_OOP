using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prectice____
{
    internal class PartTime : Employee
    {
        private double commission { get; set; }



        public PartTime(string id, string name, double salary, MidDate joiningDate, double commission) : base(id, name, salary, joiningDate)
        {
            this.commission = commission;
        }



        public override void GrossIncome()
        {
            Console.WriteLine("Over all salary for full time employee with 2 time bonus");
            double finalSalary = base.salary + commission;

            Console.WriteLine($": {finalSalary}");
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Id : {base.id}");
            Console.WriteLine($"Name : {base.name}");
            Console.WriteLine($"Salary : {base.salary}");
            Console.WriteLine($"Joing Date : {base.joiningDate.showDate()}");

        }
    }
}