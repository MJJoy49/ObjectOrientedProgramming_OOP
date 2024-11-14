using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.SetId(110);
            employee1.SetName("Mr.tom");
            employee1.SetSalary(5000);


            Employee employee2 = new Employee();
            employee2.SetId(210);
            employee2.SetName("Mr.Jerrey");
            employee2.SetSalary(10000);



            Bank bank1 = new Bank();
            bank1.SetName("Mr. Tom");
            bank1.SetAcconuntNumber(193392);
            bank1.SetBalance(20000.3);

            Bank bank2 = new Bank();
            bank2.SetName("Mr. Jerrey");
            bank2.SetAcconuntNumber(393392);
            bank2.SetBalance(90000.5);



            employee1.employeeDetails();
            bank1.bankDetails();
            employee2.employeeDetails();
            bank2.bankDetails();




            Console.ReadKey();
        }
    }
}
