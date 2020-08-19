using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Example
{
    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccountService Processor { get; set; }
    }
}
