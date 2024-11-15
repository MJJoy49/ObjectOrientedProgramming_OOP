using System;

namespace CopyConstructor_Or_Reference
{
    internal class Doctor
    {

        public string name;
        public string specialty;
        public double visitFree;

        //NO perameter constructor
        Doctor() { }

        // this is Destructor. its call Automatically
        ~Doctor() {
            Console.WriteLine("Hi, I am destructor");
        }



        public Doctor(string name, string specialty, double visitFree)
        {
            this.name = name;
            this.specialty = specialty;
            this.visitFree = visitFree;

        }


        ////copy constructor--------------
        //public Doctor(ref Doctor doctor)
        //{
        //    this.name = doctor.name;
        //    this.specialty = doctor.specialty;
        //    this.visitFree = doctor.visitFree;

        //}


        public void showDetails()
        {
            Console.WriteLine($"--------------------");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Specialty: {this.specialty}");
            Console.WriteLine($"Visit Free: {this.visitFree}");
            Console.WriteLine($"--------------------");

        }







    }  
}