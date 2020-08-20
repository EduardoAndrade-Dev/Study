using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Example
{
    public class Nurse : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountNurse();
    }
}
