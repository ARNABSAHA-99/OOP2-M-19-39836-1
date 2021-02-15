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
            Student s1 = new Student("ARNAB","19398361","CSE", 1.50f); //Constructor parameter value initialization for Student Class
            s1.ShowInfo(); //method calling
           
            Triangle t1 = new Triangle(10,10,20); //Constructor parameter value initialization for Triangle Class
            t1.ShowTriangleInfo(); //method calling
            t1.TestTriangle(); //method calling

            Account a1 = new Account("ARNAB SAHA", "112233", 5000); //Constructor parameter value initialization for Account Class
            a1.ShowAccInfo(); //method calling
            a1.Deposit(100); //method calling
            a1.Withdraw(1000); //method calling

            Course c1 = new Course("OOP2", "2210", 3); //Constructor parameter value initialization for Course Class
            c1.ShowCourseInfo(); //method calling



        }
    }
}
