using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._05_DIP_Principle.Exercise
{
    public class Email : IEmailMessage
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }
    }
}
