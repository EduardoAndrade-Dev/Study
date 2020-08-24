using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._01_CREACIONAL_Builder.Exercise
{
    public class Car
    {
        public string Name { get; set; }
        public string Model{ get; set; }

        public string Message => $"Mi Automovil es {Name}, Modelo: {Model}";
    }
}
