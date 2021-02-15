using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_3
{
    class Account
    {
        string accName; //Member fileds as by default private
        string accid;
        int balance;

        //Properties
        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Accid
        {
            set { accid = value; }
            get { return accid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public Account (string accName, string accid, int balance) //Constructor with 3 parameter
        {
            Console.WriteLine("Constructor with 3 parameter...");
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
        }

        public void ShowAccInfo()
        {
            Console.WriteLine("Account Name is: "+accName);
            Console.WriteLine("Account Id is: "+accid);
            Console.WriteLine("Account Balance is: "+balance);
        }
        public void Deposit(int amount) //Deposit method
        {
            balance = balance + amount;
            {
                Console.WriteLine("Money Added in your Account...\n Your current balance is: "+balance);
            }
        }

        public void Withdraw(int amount) //Withdraw method
        {
            balance = balance - amount;
            {
                Console.WriteLine("Money Deduct from your Account!!!!\n Your current balance is: " + balance);
            }
        }
    }
}
