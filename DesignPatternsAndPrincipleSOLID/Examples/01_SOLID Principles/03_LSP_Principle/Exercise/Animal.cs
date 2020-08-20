using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._03_LSP_Principle.Exercise
{
    public class Animal : IAnimal
    {
        public string noise { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine(noise);
        }
    }
}
