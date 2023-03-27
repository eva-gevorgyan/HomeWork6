using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCheck
{
    internal class CreateAccount:Props
    {
        public string UserName { get; set; }
        //private string surname { get; set; }
        private string password { get; set; }
        private int ID = 52;
        public bool createAcc;
        public void Check(int ID, ref bool createAcc)
        {
            if (createAcc == true)
            {
                Console.WriteLine("Create Account");
            }
        }
    }
}
