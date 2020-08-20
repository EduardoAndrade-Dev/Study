using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Example
{
    public class AccountNurse : IAccountService
    {
        public Staff Create(IApplicant person)
        {
            Staff newStaff = new Staff()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Email = $"{person.FirstName}.{person.LastName}@nurse.com"
            };

            return newStaff;
        }
    }
}
