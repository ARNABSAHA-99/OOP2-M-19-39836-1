using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_5
{
    class Savings : Account
    {
        private int minBalance = 430;

        public int MinBalance
        {
            get { return minBalance; }
            set { minBalance = value; }
        }
        public Savings() { Console.WriteLine("Default Constructor;"); }
        public Savings(string accName, string accid, int balance) : base(accName, accid, balance)
        {
            Console.WriteLine("3 parameter constructor;");
            this.AccName = accName;
            this.AccName = accid;
            this.Balance = balance;

        }
        new public void Deposit(int amount)
        {
            base.Deposit(amount);
        }
        new public void Withdraw(int amount)
        {
            if ((base.Balance - amount) >= minBalance)
            {
                base.Withdraw(amount);
                Console.WriteLine("Sufficient Balance to transfer Money");

            }
            else Console.WriteLine("Insufficient Balance to transfer Money");
            Console.WriteLine("********************");
        }
        new public void Transfer(int amount, Account acc)
        {
            if ((base.Balance - amount) >= minBalance)
            {
                base.Transfer(amount, acc);
                Console.WriteLine("Sufficient Balance to transfer Money");
            }
            else Console.WriteLine("Insufficient Balance to transfer Money");
            Console.WriteLine("********************");
        }
    }

}
