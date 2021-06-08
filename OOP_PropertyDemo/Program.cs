using System;
using System.Net;

namespace OOP_PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // OldStudent student = new OldStudent();
            // student.SetName("amir");
            // student.SetPassword("12345");
            // student.SetAge(12);
            // student.SetSurName("rezaii");
            //// Console.WriteLine(student.GetPassword());
            // Console.WriteLine(student.GetName());
            // Console.WriteLine(student.GetFullName());

            Student student = new Student();
            student.Name = "amir";
            student.SurName = "amiri";
            student.Age = 16;
            // student.Username = "a@a";
            student.Password = "a@a12354";

            Console.WriteLine(student.Name);
            Console.WriteLine(student.SurName);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Username);
            //Console.WriteLine(student.Password);


           

            Console.ReadKey();

        }
    }
}
