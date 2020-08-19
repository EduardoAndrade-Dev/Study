using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Exercise
{
    public class AreaCalculator
    {
        public string Area(List<IShape> Shapes)
        {
            string area = "";
            foreach (var shape in Shapes)
            {
                area += shape.Area();
                
                area += Environment.NewLine;
            }

            return area;
        }
    }
}
