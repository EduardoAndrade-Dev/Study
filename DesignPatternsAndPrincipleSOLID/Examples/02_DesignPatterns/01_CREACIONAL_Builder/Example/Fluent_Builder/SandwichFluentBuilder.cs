using Examples._02_DesignPatterns._01_CREACIONAL_Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._01_CREACIONAL_Builder_FluentBuilder
{
    public class SandwichFluentBuilder
    {
        public SandwichFluentBuilder()
        {
            _sandwich = new Sandwich();
        }

        public Sandwich Sandwich
        {
            get { return _sandwich; }
        }

        protected Sandwich _sandwich ;
        public SandwichFluentBuilder WithMeat()
        {
            _sandwich.Protein = "carne";
            return this;
        }

        public SandwichFluentBuilder WithCheeseChedar()
        {
            _sandwich.Cheese = "Queso Chedar";
            return this;
        }

        public SandwichFluentBuilder WithMayonesa()
        {
            _sandwich.Condiments = "Mayonesa";
            return this;
        }

        public SandwichFluentBuilder WithMostaza()
        {
            _sandwich.Condiments = "Mostaza";
            return this;
        }

    }
}
