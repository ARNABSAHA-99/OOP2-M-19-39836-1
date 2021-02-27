﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Employee : Person
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee() { Console.WriteLine("Employee Default"); }
        public Employee(string name,string id,double salary)

        {
            Console.WriteLine("Employee 3 parameter");
            this.Name = name;
            this.Id = id;
            this.salary = salary;
        }
        
       new public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary: "+salary);
        }
       /* public void ShowInfo()
        {
          
            Console.WriteLine("Salary: " + salary);
        }*/
    }
}
