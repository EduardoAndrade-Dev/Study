using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles.SRP___Single_Responsability.Example
{
    public class Appointment
    {
        public DateTime Time { get; set; }
        public Patient Patient { get; set; }
    }
}
