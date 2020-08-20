using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._04_ISP_Principle.Exercise
{
    public class Car : IVehicle, IEngine
    {
        public int GetNumberOfWheel()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public int startEngine()
        {
            throw new NotImplementedException();
        }

        public int stopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
