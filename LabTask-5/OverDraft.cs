using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_5
{
    class OverDraft : Account
    {
        private int limit;

        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }
        public OverDraft() { Console.WriteLine("Default Constructor;"); }
        public OverDraft(string accName, string accid, int balance, int limit) : base(accName, accid, balance)
        {
            Console.WriteLine("4 parameter constructor;");
            this.AccName = accName;
            this.AccName = accid;
            this.Balance = balance;
            this.limit = limit;
            base.Balance = balance + limit;
        }
        new public void Deposit(int amount)
        {
            base.Deposit(amount);
        }
        new public void Withdraw(int amount)
        {
            if (base.Balance >= amount)
                base.Withdraw(amount);
            Console.WriteLine("********************");
        }
        new public void Transfer(int amount, Account acc)
        {
            if (base.Balance >= amount)
                base.Transfer(amount, acc);
            Console.WriteLine("********************");
        }




    }
}