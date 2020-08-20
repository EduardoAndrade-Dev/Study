using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Exercise
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public string Area()
        {
            return  "Rectangulo: " + Width * Height;
        }
    }
}
