using System;



namespace For_IT_Company
{
    abstract class Employee
    {
        protected string id { set; get; }
        protected string name { set; get; }
        protected double salary { set; get; }
        protected MidDate joiningDate { set; get; }


        public Employee(string id, string name, double salary ,MidDate joiningDate) 
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joiningDate = joiningDate;
        }


        public abstract void GrossIncome();
        public abstract void ShowInfo();

    }
}
