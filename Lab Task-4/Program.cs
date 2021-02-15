using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.Write("Reverse value array1: ");
            for (int i = array1.Length; i > 0; i--)
            {
                Console.Write(array1[i - 1] + " ");
            }
            Console.WriteLine();


            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            Console.WriteLine("Sum of the all array element: "+sum);

            int[] array2 = new int[8];

            Console.Write("Copy the array1 element into array2: ");

            for (int m = 0; m < array1.Length; m++)    
            {
                array2[m] = array1[m];
            }
            for (int n = 0; n < array2.Length; n++)
            {
                Console.Write(array2[n] + " ");
            }
            Console.WriteLine();

        }
    }
}
