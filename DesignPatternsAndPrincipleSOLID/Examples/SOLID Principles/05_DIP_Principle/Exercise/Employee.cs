using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._05_DIP_Principle.Exercise
{
    public class Employee
    {
        private IEmailMessage _email;
        private ISMSMessage _sms;

        public Employee(IEmailMessage email, ISMSMessage sms)
        {
            _email = email;
            _sms = sms;
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
