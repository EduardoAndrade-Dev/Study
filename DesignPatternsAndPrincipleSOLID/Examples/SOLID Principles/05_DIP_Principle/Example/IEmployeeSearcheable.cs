using System;
using System.Collections.Generic;
using System.Text;
using static Examples.SOLID_Principles._05_DIP_Principle.Example.Enumeration;

namespace Examples.SOLID_Principles._05_DIP_Principle.Example
{
    public interface IEmployeeSearcheable
    {
        int GetEmployeeByGenderAndRole(Gender gender, Role role);
    }
}
