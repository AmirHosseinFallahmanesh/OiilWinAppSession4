using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassDemo01
{
    class Program
    {//DRY DO NOT REPEAT YOUR SELF
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Sum(12, 16, 16, 18);
            Random random = new Random();
            random.Next();



        }
    }
    class Calculator
    {
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public int Sum(int a, int b,int c)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c,int e)
        {
            return a + b+c+e;
        }
        public float Divide(int a, int b)
        {
            return a / b;
        }
    }
}
