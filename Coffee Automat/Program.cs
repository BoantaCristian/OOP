using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Automat
{
    class Program
    {
        public class Ingredient
        {
            public Ingredient()
            {

            }

            private string Name { get; set; }
            private double Cost { get; set; }
            private int Stock { get; set; }

            public string getName()
            {
                return Name;
            }
            public void setName(string name)
            {
                Name = name;
            }
            public double getCost()
            {
                return Cost;
            }
            public void setCost(double cost)
            {
                Cost = cost;
            }
            public int getStock()
            {
                return Stock;
            }
            public void setStock(int stock)
            {
                Stock = stock;
            }

        }
        public class Coffee : Ingredient
        {
            public Coffee()
            {

            }
            public string Name { get; set; }
            private static double Price = 0;
            public double getPrice()
            {
                return Price;
            }
            public void setPrice(double price)
            {
                Price = price;
            }
            public void updatePrice(double cost, int count)
            {
                var newPrice = getPrice() + cost * count;
                setPrice(newPrice);
            }
            public List<object> IngredientListForCoffee = new List<object>();
            public void addIngredientToCoffee(Ingredient ingredient, int ingredientCount)
            {
                IngredientListForCoffee.Add(new { name = ingredient.getName(), ingredientCount });
                updatePrice(ingredient.getCost(), ingredientCount);
            }
        }        
        //functions
        public static void addIngredient(string name, double cost, int stock)
        {
            var ingredient = new Ingredient();
            ingredient.setName(name);
            ingredient.setCost(cost);
            ingredient.setStock(stock);

            IngredientList.Add(ingredient);
        }
        public static void addCoffee(string name, string[] ingredientName, int[] quantity)
        {
            var coffee = new Coffee();

            coffee.Name = name;
            foreach (Ingredient ingredient in IngredientList)
            {
                for (int item = 1; item <= ingredientName.Length; item++)
                {
                    if (ingredient.getName() == ingredientName[item])
                    {
                        coffee.addIngredientToCoffee(ingredient, quantity[item]);
                    }
                }
            }

            CoffeeList.Add(coffee);
        }
        public static void fulfillStock()
        {
            foreach (var item in IngredientList)
            {
                item.setStock(30);
            }
        }
        public static void updateStock(Coffee coffee)
        {
            foreach (var item in IngredientList)
            {
                var currentStock = item.getStock();
                //foreach elem in IngredientListForCoffee check name and get ingredientCount
                item.setStock(currentStock/* - ingredientCount*/);
            }
        }
        public static bool checkStock(Coffee coffee)
        {
            var enough = true;
            //... foreach elem in IngredientListForCoffee ... if elem.count > ingr.getStock return !enough;
            return enough;
        }
        public static void prepareCoffee(Coffee coffee)
        {
            foreach (var item in CoffeeList)
            {
                if (item.Name == coffee.Name)
                {
                    if (!checkStock(coffee))
                    {
                        fulfillStock();
                    }
                    else
                    {
                        updateStock(coffee);
                        displayPrice(coffee);
                    }
                }

            }
        }
        public static void displayPrice(Coffee coffee)
        {
            Console.WriteLine(coffee.getPrice());
        }
        static List<Ingredient> IngredientList = new List<Ingredient>();
        static List<Coffee> CoffeeList = new List<Coffee>();
        static void Main(string[] args)
        {
            addIngredient("Coffee", 1.5, 10);
            addIngredient("Milk", 0.5, 10);
            addIngredient("Sugar", 0.2, 10);

            addCoffee("strong coffee", new string[] { "Coffee" }, new int[] { 3 });
            addCoffee("latte", new string[] { "Coffee", "Milk" }, new int[] { 3, 2 });
            addCoffee("long coffee", new string[] { "Coffee", "Milk", "sugar" }, new int[] { 3, 2, 1 });

            var option = Console.ReadLine();

            var currentCoffee = CoffeeList.Where(w => w.getName() == option).FirstOrDefault();

            prepareCoffee(currentCoffee);

            //or switch
            //switch (option)
            //{
            //    case "strong coffee":
            //        {
            //            //prepare
            //            break;
            //        }
            //    case "latte":
            //        {
            //            //prepare
            //            break;
            //        }
            //    case "long coffee":
            //        {
            //            //prepare
            //            break;
            //        }
            //    default:
            //        break;
            //}
        }
    }
}
