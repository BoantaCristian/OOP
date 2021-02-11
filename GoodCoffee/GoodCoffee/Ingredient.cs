using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCoffee
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; } = 1;
        public double Price { get; set; }
        public Ingredient()
        {
            Console.WriteLine("Ingredient created!");
        }
        public Ingredient(int quantity)
        {
            Quantity = quantity;

            Console.WriteLine("Ingredient created with quantity!");
        }
    }
}
