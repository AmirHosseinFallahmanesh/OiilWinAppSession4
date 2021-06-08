using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "reza";
            student1.SurName = "rezaii";
            student1.Average = 14.2f;
            student1.BirthDate = new DateTime(2010, 5, 5);
            Console.WriteLine( student1.GetInformation() );

            Student student2 = new Student();
            student1.Name = "sina";
            student1.SurName = "sinaii";
            student1.Average = 16.2f;
            student1.BirthDate = new DateTime(2010, 5, 5);


            Teacher teacher1 = new Teacher();
            teacher1.Name = "ali";
            teacher1.SurName = "alavi";
            teacher1.HiredDate = DateTime.Now;
           teacher1.

           
            Console.ReadKey();


        }
    }
}
