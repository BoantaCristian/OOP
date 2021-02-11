using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCoffee
{
    public class VendingMachine
    {
        public List<Coffee> items = new List<Coffee>();
        public void AddItem(Coffee item)
        {
            items.Add(item);
            Console.WriteLine("Item added!");
        }
    }
}
