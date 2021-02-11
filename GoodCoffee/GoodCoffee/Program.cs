using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient1 = new Ingredient();
            var ingredient2 = new Ingredient(2);

            var coffee = new Coffee();

            coffee.AddIngredient(ingredient1);
            coffee.AddIngredient(ingredient2);

            var vendingMachine = new VendingMachine();

            vendingMachine.AddItem(coffee);

            Console.Read();
        }
    }
}
