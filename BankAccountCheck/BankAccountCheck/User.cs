using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCheck
{
    internal class User:Props
    {
        public bool b;
        public string newUserName { get; set; }
        public int newID { get; set; }
        public User(string newUserName, int newID)
        {
            this.newUserName = newUserName;
            this.newID = newID;
            Check(ID, ref b);
        }
    }
}
