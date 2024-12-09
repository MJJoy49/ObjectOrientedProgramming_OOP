using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prectice____
{
    internal class MidDate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        
        
        
        public MidDate(int day, int month, int year) 
        { 
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public  string  showDate()
        {
           return $"{day}/{month}/{year}";
        }

    }
}
