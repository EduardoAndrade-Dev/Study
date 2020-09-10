using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example2
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(TypeOfPizza type);

        public Pizza OrderPizza(TypeOfPizza type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }
    }
}
