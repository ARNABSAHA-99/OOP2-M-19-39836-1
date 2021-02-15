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
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };

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

            //3

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

            //4

            int[] array3 = { 1, 1, 2, 3, 4, 4, 5, 6, 6, 7,10,10,149,149 };
            for (int z = 0; z < array3.Length; z++)
            {
                for (int y = z + 1; y < array3.Length; y++)
                {
                    if (array3[z] == array3[y])
                        Console.WriteLine("{0} has 2 duplication.", array3[z]);
                }
            }
            Console.WriteLine();

            //5

            int[] array4 = { 1,2,3,4,5 };
            for (int w = 0; w < array4.Length; w++)
            {
                for (int q = w + 1; q < array4.Length; q++)
                {
                    if (array3[w] != array4[q])
                        Console.WriteLine("{0} is unique number.", array4[w]);
                }
            }
            Console.WriteLine();

        }
    }
}
