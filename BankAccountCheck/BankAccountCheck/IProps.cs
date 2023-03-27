using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCheck
{
    abstract class Props
    {
        public int ID { get; set; }
        public int MaxLength { get; set; } = 9;
        public string UserName { get; set; }
        public void Check(int ID, ref bool b)
        {
            if (ID.ToString().Length == MaxLength)
            {
                Console.WriteLine($"Welcome to your account.");
                //chreateAcc = false;
            }
            else
            {
                b = true;
            }
        }
    }
}
