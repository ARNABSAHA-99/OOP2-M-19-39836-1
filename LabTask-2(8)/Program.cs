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
            double physics = 50;
            double chemistry = 40;
            double biology = 30;
            double math = 90;
            double computer = 60;
            double mark = 0;

            mark = physics + chemistry + biology + math + computer;
            mark = (100 * mark) / 500;

            if (mark >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (mark >= 85 && mark < 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (mark >= 80 && mark < 85)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (mark >= 75 && mark < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (mark >= 50 && mark < 75)
            {
                Console.WriteLine("Grade: C+");
            }
            else if (mark < 50)
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}
