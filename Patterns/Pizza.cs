using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppingList = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing "+name);
            Console.WriteLine("Tossing dough "+dough);
            Console.WriteLine("Adding sauce... ");
            Console.WriteLine("Adding toppings: ");
            foreach(string topping in toppingList)
            {
                Console.WriteLine(" "+topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 min at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official pizzaStore box");
        }

        public string getName()
        {
            return name;
        }
    }
}
