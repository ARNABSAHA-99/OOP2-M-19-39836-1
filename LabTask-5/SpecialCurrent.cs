using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_5
{
    class SpecialCurrent : Account
    {
        int minBalance;
        private int openingBalance;

        public int OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }
        public SpecialCurrent() { Console.WriteLine("Default Constructor;"); }
        public SpecialCurrent(string accName, string accid, int balance) : base(accName, accid, balance)
        {
            Console.WriteLine("3 parameter constructor;");
            this.AccName = accName;
            this.AccName = accid;
            this.Balance = balance;
            openingBalance = balance;
            minBalance = (openingBalance * 10) / 100;
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