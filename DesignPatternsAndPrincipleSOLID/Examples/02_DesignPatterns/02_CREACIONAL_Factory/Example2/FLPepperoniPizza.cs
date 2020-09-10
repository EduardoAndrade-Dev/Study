using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example2
{
    internal class FLPepperoniPizza : Pizza
    {
        public FLPepperoniPizza()
        {
            Name = "Pepperoni";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }
}
