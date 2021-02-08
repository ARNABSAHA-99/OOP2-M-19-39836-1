using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 56; //literals
           // const int credit=148;
            a = 45;

            int n=105; /*declaration!!! If it is local variable and you will use this variable then you must initialize the value. Otherwise, get error.
            /But, if you will not use this variable anywhere then their is no probelm! In that time initialize the value or not doesn't matter.
            /On the other hand, take value from the console is different case. You can do it.
            Console.WriteLine("N is :" +n); */


            Student s1 = new Student("ARNAB","39836"); //2 parameterize constructor calling when createing the instance
            s1.ShowInfo(); //ShowInfo method calling

            s1.Name = "ARNAB SAHA"; //change variable using set method
            s1.Id = "14873"; //change variable using set method
            Console.WriteLine("Name is " +s1.Name);
            Console.WriteLine("Id is " +s1.Id);
            

            
        }
    }
}
