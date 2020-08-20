using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._01_CREACIONAL_Builder
{
    public abstract class SandwichBuilder
    {
        public Sandwich Sandwich
        {
            get { return _sandwich; }
        }

        protected Sandwich _sandwich ;
        public abstract void AddBread();
        public abstract void AddProtein();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }
}
