using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 10;
            Console.Write("Z=");
            int z = int.Parse(Console.ReadLine());
            Console.Write("Sum of three number:");
            int sumoftwonumber = x + y + z;
            Console.WriteLine(sumoftwonumber);
            Console.Write("Subtraction of two number:");
            int subtractionoftwonumber = x - y;
            Console.WriteLine(subtractionoftwonumber);
            Console.Write("Multiplication of two number:");
            int multipleoftwonumber = x * y;
            Console.WriteLine(multipleoftwonumber);
            Console.Write("Division of two number:");
            int Divisionoftwonumber = x / y;
            Console.WriteLine(Divisionoftwonumber);

        }
    }
}
