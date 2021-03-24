using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class PizzaStore //client
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type); //return object based on type

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        public abstract Pizza CreatePizza(string type); //responsible to create objects
    }
}
