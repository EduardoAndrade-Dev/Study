using Examples._02_DesignPatterns._01_CREACIONAL_Builder.Fluent_Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesTests._02_DesignPatterns._01_CREACIONAL_Builder.Fluent_Builder
{
    public class GreetingBuilder
    {
        private readonly Greet _greeting;

        public GreetingBuilder()
        {
            _greeting = new Greet();
        }

        public static GreetingBuilder CreateNew()
        {
            return new GreetingBuilder();
        }

        public GreetingBuilder TimeOfDay(string timeOfDay)
        {
            _greeting.TimeOfDay = timeOfDay;
            return this;
        }

        public GreetingBuilder To(string to)
        {
            _greeting.To = to;
            return this;
        }

        public Greet Build()
        {
            return _greeting;
        }
    }
}
