using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_IT_Company
{
    internal class MidDate
    {
        private int day {  get; set; }
        private int month {  get; set; }
        private int year { get; set; }


        public MidDate(int day, int month, int year) 
        { 
            this.day = day; 
            this.month = month; 
            this.year = year; 
        }

        public string GetFormattedDate() 
        { 
            return $"{this.day}/{this.month}/{this.year}"; 
        }
    }
}


