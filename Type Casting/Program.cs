using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
            int a = 10;
            Console.WriteLine("The value of a is: "+a);
            float f = 10.784f;
            Console.WriteLine("The is value of f is: {0}",f);
            Console.WriteLine("The value of a is {0} and the value of f is {1}",a ,f);

            //implicit casting
            short s = 10; //a cup of tea
            int i; // an empty kettllee
            i = s;
            //explicit casting
            int j = 28794567; // a kettllee full of tea
            short h; //an empty cup
            h =(short) i;

            int m = 4; //a kettllee with half cup tea
            short n; //an empty cup
            n = (short)m;

            Console.WriteLine("J={0}\nh={1}\n\nm={2}\nn={3}",j,h,m,n);


        }
    }
}
