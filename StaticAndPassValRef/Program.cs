using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPassValRef
{
    class Program
    {
        void demo() { }
        static void DemoTrain() { }
       
        static void swap(ref int x,ref int y) 
        { 
            int temp = x;
            x = y;
            y = temp;
            //Console.WriteLine("x= {0} and y= {1}", x, y); //x=12,y=10

        }

        static void SwapOut(out int a)
        {
            a = 10500;
            a = a * a;
        }

      
        static void Main(string[] args)
        {


            int x = 10, y = 12;
            Console.WriteLine("x= {0} and y= {1}",x,y); //x=10,y=12
            swap(ref x, ref y);
            Console.WriteLine("x= {0} and y= {1}", x, y); //x=10,y=12

            /* Student s1 = new Student("ARNAB", "1234");
             Student s2 = new Student("ARNAB SAHA", "1234567");
             Student s3 = new Student("ANKETA", "1234567447477");
             Console.WriteLine("NAME IS {0}, NAME IS {1}", s1.Name, s2.Name);
             Console.WriteLine("Total Count is: "+Student.count);

             Program p = new Program();
             p.demo();
             DemoTrain();*/

            int a = 100;
            SwapOut( out a);
            Console.WriteLine(a);






        }
    }
}
