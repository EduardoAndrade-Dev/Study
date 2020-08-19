using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Exercise
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public string Area()
        {
            return "Circulo: " + Radius * Radius * Math.PI;
        }
    }
}
