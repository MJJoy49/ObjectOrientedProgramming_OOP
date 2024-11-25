using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSystem
{
    internal class User
    {
        private string _UserName;
        private string _Password;


        public User(string _UserName, string _Password)
        {
            this._UserName = _UserName;
            this._Password = _Password;
        }

        public void setUserName(string userName)
        { this._UserName = userName; }


        public string getUserName()
        {
            return this._UserName;
        }



        public void setPassword(string _Password)
        { this._Password = _Password; }


        public string getPassword()
        {
            return this._Password;
        }
    }
}
