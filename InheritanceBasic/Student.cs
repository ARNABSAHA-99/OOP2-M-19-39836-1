using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Student: Person
    {
      
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student() :base("","")
        {
            Console.WriteLine("Student Default");
        }
        public Student(string name, string id)
        {
            Console.WriteLine("Student 2 parameter");
            this.Name = name;
            this.Id = id;
        }

       new public void ShowInfo() //method overriding //function name //parameter list should be same to be override
        {
           base.ShowInfo();
            Console.WriteLine("Cgpa: " + cgpa);


        }
      /*  public void ShowInfo()
        {
   
            Console.WriteLine("Cgpa: "+cgpa);
        }*/
    }
}
