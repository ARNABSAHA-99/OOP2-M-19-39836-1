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
            //1
            int[] array1 = { 1, 2, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10, 10, 11 };

            Console.Write("Reverse value array1: ");
            for (int i = array1.Length; i > 0; i--)
            {
                Console.Write(array1[i - 1] + " ");
            }
            Console.WriteLine();


            //2
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            Console.WriteLine("Sum of the all array element: "+sum);
            Console.WriteLine();

            //3

            int[] array2 = new int[14];

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

            //4

            int[] duplicate = new int[14];
            for (int y = 0; y < array1.Length; y++)
            {
                for (int z = y + 1; z < array1.Length; z++)
                {
                    if (array1[y] == array1[z])
                    {
                        Console.WriteLine("Number {0} has a duplication.", array1[y]);
                        duplicate[z] = array1[y];
                    }
                }
            }
            Console.WriteLine();

            //5

            for (int p = 0; p < array1.Length; p++)
            {
                int unique = 0;
                for (int q = 0; q < duplicate.Length; q++)
                {
                    if (array1[p] == duplicate[q])
                        unique = 1;
                }
                if (unique == 0)
                    Console.WriteLine("Number {0} is unique.", array1[p]);
            }

        }
    }
}
