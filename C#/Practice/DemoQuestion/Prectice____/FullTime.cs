using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prectice____
{
    internal class FullTime:Employee
    {

        private double bonus {  get; set; }


        public FullTime(string id, string name, double salary, MidDate joiningDate, double bonus):base(id, name, salary, joiningDate)
        {
            this.bonus=bonus;
        }



        public override void GrossIncome() 
        {
            Console.WriteLine("Over all salary for full time employee with 2 time bonus");
            double finalSalary = (base.salary
                * 12) + (bonus * 2);

            Console.WriteLine($": {finalSalary}");
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Id : {base.id}");
            Console.WriteLine($"Name : {base.name}");
            Console.WriteLine($"Salary : {base.salary}");
            Console.WriteLine($"Joing Date : {joiningDate.showDate()}");

        }

        



    }
}
