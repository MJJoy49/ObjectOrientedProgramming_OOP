using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSystem
{
    internal class Admin:User
    {
        private Boolean IsAdmin { get; set; }

        private String Name { get; set; }

        public Admin(String Name,bool IsAdmin, string Username, string Password): base(Username, Password)
        {
            this.Name = Name;
            this.IsAdmin = IsAdmin;
        }


        public void showDetails()
        {
            Console.WriteLine($"{this.Name}    {this.IsAdmin}   {this.Username} {this.password}");
        }



    }
}
