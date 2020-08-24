using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._01_CREACIONAL_Builder
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;

        public SandwichAssembly(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void Assembly()
        {
            _sandwichBuilder.AddBread();
            _sandwichBuilder.AddCheese();
            _sandwichBuilder.AddCondiments();
            _sandwichBuilder.AddProtein();
            _sandwichBuilder.AddVeggies();
        }

        public Sandwich GetSandwich
        {
            get { return _sandwichBuilder.Sandwich; }
        }
    }
}
