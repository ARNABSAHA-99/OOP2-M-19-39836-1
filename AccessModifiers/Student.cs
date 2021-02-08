using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Student
    {
        string name;
        string id;
        float cgpa;
        readonly int credit;

        //properties or accessors

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        } 
        
        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public float Cgpa
        {
            get { return this.cgpa; }
        }
       public Student() //empty constructor which has no parameter
        {
            Console.WriteLine("Student Created with default");
            credit = 145;
        }
        
       public Student(string name, string id) //constructor which contain 2 parameter
        {
            Console.WriteLine("Student Created with 2 parameter"); 
            this.name = name;
            this.id = id;
            credit = 148;

        }


        public void ShowInfo() // ShowInfo method
        {
            Console.WriteLine("Name is: " +name);
            Console.WriteLine("Id is: " +id);
            Console.WriteLine("Cgpa is: " +cgpa);
        }
    }
}
