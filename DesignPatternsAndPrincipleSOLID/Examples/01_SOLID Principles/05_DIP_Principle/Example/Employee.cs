using System;
using System.Collections.Generic;
using System.Text;
using static Examples.SOLID_Principles._05_DIP_Principle.Example.Enumeration;

namespace Examples.SOLID_Principles._05_DIP_Principle.Example
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }
    }
}
