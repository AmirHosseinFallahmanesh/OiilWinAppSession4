using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PropertyDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            stock.Update(160000);
        }
    }
    class Stock
    {
        public int Price { get; private set; }

        public void Update(int newPrice)
        {
            Price = newPrice;
        }



    }
}
