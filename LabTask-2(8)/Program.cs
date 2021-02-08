using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_2_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            double physics = 95;
            double chemistry = 70.8;
            double biology = 82.2;
            double math = 97;
            double computer = 90;
            double sum = 0.0;

            sum = physics + chemistry + biology + math + computer;
            sum = (100 * sum) / 500;

            if (sum >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (sum >= 85 && sum < 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (sum >= 80 && sum < 85)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (sum >= 75 && sum < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (sum >= 50 && sum < 75)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.WriteLine("");
        }
    }
}
