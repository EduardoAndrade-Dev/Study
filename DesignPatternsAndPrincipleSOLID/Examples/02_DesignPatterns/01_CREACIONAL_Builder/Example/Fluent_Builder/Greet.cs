using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._01_CREACIONAL_Builder.Fluent_Builder
{
    public sealed class Greet
    {
        public string TimeOfDay;
        public string To;

        public string Message => $"Buenas {TimeOfDay} {To}";
    }
}
