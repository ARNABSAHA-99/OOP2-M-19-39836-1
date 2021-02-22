using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private string bloodGrp;

        public string BloodGrp
        {
            get { return bloodGrp; }
            set { bloodGrp = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Blood Grp: " + bloodGrp);
            Console.WriteLine("Dob: " + dob);
        }

    }
}
