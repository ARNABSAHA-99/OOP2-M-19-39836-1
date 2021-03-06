﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_3
{
    class Triangle
    {
        int x; //Member fileds as by default private
        int y;
        int z;

        //properties
        public int X
        {
            set { x = value; }
            get { return x; }
        } 
        
        public int Y
        {
            set { y = value; }
            get { return y; }
        } 
        
        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public Triangle(int x, int y,int z) //constructor with 3 parameter
        {

            Console.WriteLine("Constructor with 3 parameter...");
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void ShowTriangleInfo()
        {
            Console.WriteLine("Value of X is :"+x);
            Console.WriteLine("Value of Y is :"+y);
            Console.WriteLine("Value of Z is :"+z);
        }

        public void TestTriangle() //TestTriangle method
        {
            if (x == y && y == z) //condition
            {
                Console.WriteLine("The triangle is equilateral");
            }

            else if(x==y || y==z|| x==z) //condition
            {
                Console.WriteLine("The triangle is isosceles");
            }

            else //condition
            {
                Console.WriteLine("The triangle is scalene");
            }
        }
    }
}
