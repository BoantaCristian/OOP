using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodCoffee
{
    public class Coffee
    {
        public string Name { get; set; }
        public double Price { get; set; } = 0;

        public List<Ingredient> Ingredients = new List<Ingredient>();

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
            Console.WriteLine("Ingrediend added!");

            CalculatePrice(ingredient);
        }
        public void CalculatePrice(Ingredient ingredient)
        {
            Price = Price + ingredient.Price * ingredient.Quantity;
            Console.WriteLine("Price updated!");
        }
    }
}
