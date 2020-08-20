using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._03_LSP_Principle.Exercise
{
    public interface IAnimal
    {
        string noise { get; set; }

        void MakeNoise();
    }
}
