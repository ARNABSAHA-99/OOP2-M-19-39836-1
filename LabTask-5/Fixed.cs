using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_5
{
    class Fixed: Account
    {
        private int tenureYear;
            readonly int year=10;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        public Fixed() { Console.WriteLine("Default Constructor;"); }
        public Fixed(string accName, string accid, int balance,int tenureYear) : base(accName, accid, balance)
        {
            Console.WriteLine("4 parameter constructor;");
            this.AccName = accName;
            this.AccName = accid;
            this.Balance = balance;
            this.tenureYear = tenureYear;
            
        }
        new public void Deposit(int amount)
        {
            base.Deposit(amount);
        }
        new public void Withdraw(int amount)
        {
            if (tenureYear>=year)
            { 
                base.Withdraw(amount);
            
                Console.WriteLine("This Account is mature");
            }
            else if(tenureYear< year)
            {
                Console.WriteLine("This Account not is mature");
            }
            
            Console.WriteLine("********************");
        }
        new public void Transfer(int amount, Account acc)
        {
            if (tenureYear>= year)
            {
                base.Transfer(amount, acc);
                Console.WriteLine("This Account is mature");
            }
            else if (tenureYear<year)
            {
                Console.WriteLine("This Account is not mature"); 
            }
            Console.WriteLine("********************");
        }


    }
}
