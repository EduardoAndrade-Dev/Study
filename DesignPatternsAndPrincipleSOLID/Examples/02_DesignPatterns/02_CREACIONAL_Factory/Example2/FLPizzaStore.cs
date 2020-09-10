using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example2
{
    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator.
                 CreateInstance(Type.GetType($"PizzaFactory.FL{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }
    }
}
