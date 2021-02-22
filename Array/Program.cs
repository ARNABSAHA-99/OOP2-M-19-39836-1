using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimensional array
            int[] arr1 = new int[5];
            arr1[0] = 1;
            arr1[1] = 45;

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 20 + i;

            }
            int[] arr2 = { 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 8, 8 };
            int[] arr3 = new int[] {665, 25, 533, 522, 522424, 55, 5, 5, 56, 54, 88, 55};
            int[] arr4 = new int[5] { 1, 2, 3, 4,56 };

            for (int i=0; i<arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]);
            }
            //2 dimensional array

            int[,] arr5 = new int[4, 2];
            arr5[0, 0] = 1;
            arr5[0, 1] = 2;
            int[,] arr6 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for(int i=0; i<4;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(arr6[i,j]+" ");
                }
                Console.WriteLine();
            }
            //jagged array is an array of array

            int[][] arr7 = new int[3][]; // first [3] is jagged array size and 2nd [] means size of every array index
            arr7[0] = new int[5]; // In 0 no index there have another 5 array index
            arr7[1] = new int[3]; // In 1 no index there have another 3 array index
            arr7[2] = new int[2]; // In 2 no index there have another 2 array index
         

            arr7[0][3] = 123; //[0] actual index no [3] inner index no where 123 is stores
            arr7[2][1] = 122; //[2] actual index no [1] inner index no where 122 is stored
            arr7[1][2] = 3; //[0] actual index no [3] inner index no where 3 is stored
          
            

            int[][] arr8=
            {
                new int [5], //0 no index size 5 means 0 no index has another 5 array size of index
                new int [5],  //1 no index size 5 means 0 no index has another 5 array size of index
                new int [6],
                new int [4],
                new int [4],
                new int [5]
                

            };
            int[][] arr9 =
            {
                new int [] {12,24,34,44,55,4,9,7,8,3},
                new int [] {11,12,23,64,54,644},
                new int [] {21,22,23}

            };
            for(int i=0; i<arr9.Length;i++)
            {
                for (int j=0; j<arr9[i].Length;j++)
                {
                    Console.Write(arr9[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
