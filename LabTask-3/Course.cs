using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_3
{
    class Course
    {
        string courseName; //Member fileds as by default private
        string courseCode;
        int courseCredit;

        //Properties
        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }

        public string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }

        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }

        public Course(string courseName,string courseCode,int courseCredit) //Constructor with 3 parameter
        {
            Console.WriteLine("Constructor with 3 parameter...");
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }


        public void ShowCourseInfo() //ShowCourseInfo method
        {
            Console.WriteLine("CourseName is: "+courseName);
            Console.WriteLine("CourseCode is: "+courseCode);
            Console.WriteLine("CourseCresit is: "+courseCredit);
        }
    }
}
