using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_2_4_
{
    class Program /*print the sum of odd and even numbers starting from1 to 100*/
    {
        static void Main(string[] args)
        {
            int i, SumOfEven=0, SumOfOdd=0;
            Console.Write("Take your desier number: ");
            int n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    SumOfEven = SumOfEven + i;
                }

                else if(i%2!=0)
                {
                    SumOfOdd = SumOfOdd + i;
                }

                Console.Write("Sum of Even Number: ");
                Console.WriteLine(SumOfEven);
                Console.Write("Sum of Odd Number: ");
                Console.WriteLine(SumOfEven);
            }
        }
    }
}
