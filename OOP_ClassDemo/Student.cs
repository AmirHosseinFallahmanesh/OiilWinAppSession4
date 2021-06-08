using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassDemo
{
    class Student
    {
        public string Name;
        public string SurName;
        public float Average;
        public DateTime BirthDate;

        public string GetInformation()
        {
            return Name + " " + SurName;
        }
    }
}
