using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example2
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            //switch (name)
            //{
            //    case "pepperoni":
            //        return new NYPepperoniPizza();
            //    case "Neapolitan":
            //        return new NYNeapolitanPizza();
            //    case "California":
            //        return new NYCaliforniaPizza();
            //    default:
            //        return null;

            //}

            return (Pizza)Activator.
                CreateInstance(Type.GetType($"Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example2.NY{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }
    }
}
