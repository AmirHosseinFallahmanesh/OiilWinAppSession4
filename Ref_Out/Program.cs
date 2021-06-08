using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainValue = 10;
            changeValue(ref mainValue);
            Console.WriteLine("main value => "+mainValue);


            int newValue;
            initValue(out newValue);
            Console.WriteLine("new value => " + newValue);

            Console.ReadKey();
        }

        static void notChangeValue(int value)
        {
            value = 25;
        }
        static void changeValue(ref int value)
        {
            value = 25;
        }

        static void initValue(out int value)
        {
            value = 30;
        }
    }


}
