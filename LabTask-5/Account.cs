using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_5
{
     class Account
    {
        string accName; 
        string accid;
        int balance;
        

        
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

        public Account() { Console.WriteLine("Default Constructor"); }

        public Account(string accName, string accid, int balance) 
        {
            
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
        }

        public void ShowAccInfo()
        {
            Console.WriteLine("Account Name is: " + accName);
            Console.WriteLine("Account Id is: " + accid);
            Console.WriteLine("Account Balance is: " + balance);
        }
        public void Deposit(int amount) 
        {
            balance = balance + amount;
            {
                Console.WriteLine("Money Added in your Account...\n Your current balance is: " + balance);
            }
        }

        public void Withdraw(int amount) 
        {
            balance = balance - amount;
            {
                Console.WriteLine("Money Deduct from your Account!!!!\n Your current balance is: " + balance);
            }
        }

        public void Transfer(int amount, Account acc)
        {
            
            if(amount<balance)
            {
                balance = balance - amount;
                acc.balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Money transfer is failed;");
            }

        }
    }
}
