using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtended
{
    class Program
    {


        enum Days
        {
            Sat=105,
            Sun,
            Mon,
            Tues=1,
            Wed=2,
            Thurs
        }

        static void Print1DArray(int[] arr)
        {
           /* for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }*/
            
            foreach(int num in arr)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }

        static void Print2DArray(string[,] arr)
        {
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void PrintJaggedArray(int[][] arr)
        {
            //for(int i=0;i<arr.Length;i++)
            //{
            //    for(int j=0;j<arr[i].Length;j++)
            //    {
            //        Console.Write(arr[i][j]+ " ");
            //    }
            //    Console.WriteLine();

            //}

            foreach (int[] inner in arr)
            {
                foreach (int num in inner)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
       /* static int Sum(int a, int b)
        {
            return (a + b);
        }
        static int Sum(int a, int b,int c)
        {
            return (a + b+c);
        }*/
       static int Sum(params int[] array)
            //params can take variable number of argument receive 
            //1.Write params key word. 2.Need a 1D array with indentifier. 3.only one params in a method.
            //4. If there any additional argument write before params. 
        {
            int sum = 0;
            foreach(int num in array)
            {
                sum += num;
            }
            return sum;
        }
         


        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Print1DArray(arr);
            int[] arr2 = { 3, 44, 5, 66, 5 };
            Print1DArray(arr2);
            string[,] arr3 =
            {
                {"Karim","Mike" },
                {"Rarim","Bike" },
                {"Mofiz","John" }


            };
            Print2DArray(arr3);

            int[][] jagged =
            {
                new int[]{1,2,3,4},
                new int[]{5,6,7,4,55,8},
                new int[]{12,32,34,43}
            };
            PrintJaggedArray(jagged);
            Console.WriteLine("****************");
            Console.WriteLine(Sum(10,20,30));
            Console.WriteLine(Sum(10,20,30,122,1212,12,12,12));
            Console.WriteLine(Sum(10,20,30,122,12));
            Console.WriteLine(Sum(10,20));
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(arr));
            Console.WriteLine("****************");
            Console.WriteLine(Days.Sat);
            Console.WriteLine((int)Days.Sat);
            Console.WriteLine((Days)105);



        }
    }
}
