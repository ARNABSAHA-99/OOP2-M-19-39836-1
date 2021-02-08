using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ARNAB","19398361","CSE", 1.50f);
            s1.ShowInfo();
           
            Triangle t1 = new Triangle(10,10,20);
            t1.TestTriangle();

            Account a1 = new Account("ARNAB SAHA", "112233", 5000);
            a1.Deposit(100);
            a1.Withdraw(1000);

            Course c1 = new Course("OOP2", "2210", 3);
            c1.ShowCourseInfo();


           
        }
    }
}
