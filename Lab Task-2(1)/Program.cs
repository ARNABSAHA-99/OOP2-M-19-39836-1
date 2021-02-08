using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_2_1_
{
    class Program //print all the even number 1 to n using for loop
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Take your desier number: ");
            int n = int.Parse(Console.ReadLine());
           
            for (i = 1; i <= n; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
