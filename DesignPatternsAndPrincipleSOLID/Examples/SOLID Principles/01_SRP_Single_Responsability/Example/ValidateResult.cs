using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.SOLID_Principles.SRP___Single_Responsability.Example
{
    public class ValidateResult
    {
        public List<string> ErrorMessage { get; set; } = new List<string>();
        public bool IsValid => !ErrorMessage.Any();
    }
}
