using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings s1 = new Savings("ARNAB SAHA", "39836",10000);
            Savings s2 = new Savings("ANIK SAHA", "75757",12000);
            s1.Deposit(5000);
            s1.Withdraw(2000);
            s1.Transfer(4000,s2);
            Console.WriteLine();
            Console.WriteLine("***********************************");


            
            SpecialCurrent sc1 = new SpecialCurrent("ARNAB SAHA", "39836", 10);
            SpecialCurrent sc2 = new SpecialCurrent("ANIK SAHA", "75757", 12000);
            sc1.Deposit(10);
            sc1.Withdraw(2000);
            sc1.Transfer(4000, sc2);
            Console.WriteLine();
            Console.WriteLine("***********************************");


            
            Fixed f1 = new Fixed("ARNAB SAHA", "39836", 10, 10000);
            Fixed f2 = new Fixed("ANIK SAHA", "75757",15, 12000);
            f1.Deposit(5000);
            f1.Withdraw(2000);
            f1.Transfer(4000, f2);
            Console.WriteLine();
            Console.WriteLine("***********************************");


            
            OverDraft od1 = new OverDraft("ARNAB SAHA", "39836", 50000, 10000);
            OverDraft od2 = new OverDraft("ANIK SAHA", "75757", 50000, 12000);
            od1.Deposit(5000);
            od1.Withdraw(2000);
            od1.Transfer(4000, od2);
            Console.WriteLine();
            Console.WriteLine("***********************************");



        }
    }
}
