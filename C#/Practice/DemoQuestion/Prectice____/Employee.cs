using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//id,
//name,
//salary
//and joining date.



namespace Prectice____
{
    internal class Employee
    {
        public  string id { get; set; }
        public  string name { get; set; }
        public double salary{ get; set; }

        public MidDate joiningDate { get; set; }


        public Employee(string id, string name, double salary, MidDate joiningDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joiningDate = joiningDate;
        }


        public virtual void ShowInfo() { }
        public virtual void GrossIncome() { }



    }
}
