using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task3
{
    internal class Employee
    {
        private string name;
        private int id;
        private double salary;


        public Employee()
        {

        }

        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }


        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }









        public void employeeDetails()
        {
            Console.WriteLine($"-----------Employee Details------------");
            Console.WriteLine($"Employee name is {this.name}");
            Console.WriteLine($"Employee id is {this.id}");
            Console.WriteLine($"Employee salary is {this.salary}");
            Console.WriteLine($" ");
        }

    }
}
