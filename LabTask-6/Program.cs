using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_6
{
    class Program  //Association
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ARNAB", "123232343", 2.5f);
            Student s2 = new Student("ARNAB SAHA", "9599343", 3.5f);
            Student s3 = new Student("ANIK", "444343", 2.95f);

            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("BBA", "FBA");

            s1.Dept = d1;
            s2.Dept = d1;
            s3.Dept = d2;

            d1.AddStudent(s1,s2,s3);
            

            s1.ShowSudentDeatils();
            s2.ShowSudentDeatils();
            s3.ShowSudentDeatils();

            Console.WriteLine("**********************");


            d1.Name = "CSSSSE";
            d1.Id = "FST";
            s1.ShowSudentDeatils();
        
        }
    }
}
