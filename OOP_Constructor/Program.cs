using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("a@a", "ali", "alavi", 100f);
            
            student.Password = "123456";
            student.Name = "amirAli";
            Console.WriteLine(student.Username);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.SurName);
          
          
            Console.ReadKey();

        }
    }
}
