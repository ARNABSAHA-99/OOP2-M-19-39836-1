using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainConstructorChainig
{
    class Student:Person
    {
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student(string name, float cgpa):base(name)
        {
            this.cgpa = cgpa;
        }

    }
}
