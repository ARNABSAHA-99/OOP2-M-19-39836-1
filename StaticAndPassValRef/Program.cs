using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPassValRef
{
    class Program
    {

       
        static void swap(int x, int y) 
        {
            int temp = x;
            x = y;
            y = temp;
         
        }

      
        static void Main(string[] args)
        {


            int x = 10, y = 12;
            Console.WriteLine("x= {0} and y= {1}",x,y); //x=10,y=12
            swap(x, y);
            swap(x, y);
            swap(x, y);
            swap(x, y);
            swap(x, y);
            swap(x, y);
            swap(x, y);
            












        }
    }
}
