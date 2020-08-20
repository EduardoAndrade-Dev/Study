using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.SOLID_Principles._05_DIP_Principle.Example
{
    public class EmployeeManager : IEmployeeSearcheable
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public int GetEmployeeByGenderAndRole(Enumeration.Gender gender, Enumeration.Role role)
        {
            return _employees.
                 Where(x => x.Gender == Enumeration.Gender.Male && x.Role == Enumeration.Role.Executive)
                 .ToList().Count;
        }

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
