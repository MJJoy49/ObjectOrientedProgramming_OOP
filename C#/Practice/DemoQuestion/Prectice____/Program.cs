using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//An IT company is willing to have their employee information
//in a console-base system,
//
//for which they asked to build a
//simple console-based application which will have some basic
//employee information.
//
//The company has 2 types of Employees: full time and part time.


//All the Employees will have
//id,
//name,
//salary
//and joining date.


//empoyee , ;fulltime, prattime, midDate



//Full-time employees will have bonus which is 50% of there salary  (salary * 0.5)
//
//
//and
//
//part-time will have commission.
//
//
//ShowInfo() method will provide all the information for each
//type of employee.
//There will be a method GrossIncome()  FUll time=>sal*12 +bonus*2 || part time =>sal+com
//
//
//for each type of employee
//which will find the total income.
//For full-time it will be calculation of 12 months
//salary and 2 bonuses per year
//
//and for part-time it will be the summation of only the
//salary per month and commission.
//
//
//
//The Main methad is already given for you. try to write
//other classes to make it happen.
//
//Write appropriate fields, methods, properties etc.
//Use proper access modifiers, types etc.
//
//[Note: For Joining date you have to create a
//custom type]//














namespace Prectice____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x=new int[10]; //16 32 duble

            x[0] = 10;


            Employee[] emp=new Employee[10];

            emp[0] = new PartTime("282","liza",100000,new MidDate(10,12,2024),20000);
            emp[1] = new PartTime("282", "liza", 100000, new MidDate(10, 12 , 2024), 20000);
            emp[2] = new PartTime("282", "liza", 100000, new MidDate(10, 12 ,2024), 20000);

            for (int i = 0; i < emp.Length; i++)
            {
                string id=Console.ReadLine();


                emp[i] = new PartTime(id,);
            }



            foreach (var e in emp)
            {
                e.ShowInfo();
                e.GrossIncome();
            }








            //Employee[] emp = new Employee[2];
            //emp[0] = new FullTime("E-001", "Saef", 30000, new MidDate(12, 09, 2013), 15000);
            //emp[1] = new PartTime("E-002", "Kawsur", 12000, new MidDate(23, 07, 2019), 1300);

            //foreach (Employee e in emp)
            //{
            //    e.ShowInfo();
            //    e.GrossIncome();
            //}



            Console.ReadKey();
        }
    }
}
