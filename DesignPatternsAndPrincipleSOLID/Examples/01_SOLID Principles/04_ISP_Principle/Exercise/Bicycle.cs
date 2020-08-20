using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._04_ISP_Principle.Exercise
{
    public class Bicycle : IVehicle
    {
        public int GetNumberOfWheel()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
