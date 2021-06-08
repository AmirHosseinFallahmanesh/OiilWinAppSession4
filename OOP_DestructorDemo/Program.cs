using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DestructorDemo
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor Invoked");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Employee e1 = new Employee();
                Employee e2 = new Employee();

            }
          
            Console.ReadKey();
        }
    }
}
