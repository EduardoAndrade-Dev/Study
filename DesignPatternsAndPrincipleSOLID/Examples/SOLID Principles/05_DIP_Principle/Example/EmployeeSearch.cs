using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._05_DIP_Principle.Example
{
    public class EmployeeSearch
    {
        private readonly IEmployeeSearcheable employeeSearch;

        public EmployeeSearch(IEmployeeSearcheable employeeSearch)
        {
            this.employeeSearch = employeeSearch;
        }

        public int GetMaleExecutives()
        {
            return employeeSearch.GetEmployeeByGenderAndRole(Enumeration.Gender.Male, Enumeration.Role.Executive);
        }

    }
}
