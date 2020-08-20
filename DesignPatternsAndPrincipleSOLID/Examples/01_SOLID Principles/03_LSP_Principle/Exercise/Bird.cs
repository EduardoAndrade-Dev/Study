using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._03_LSP_Principle.Exercise
{
    public class Bird : Animal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("Estoy volando");
        }
    }
}
