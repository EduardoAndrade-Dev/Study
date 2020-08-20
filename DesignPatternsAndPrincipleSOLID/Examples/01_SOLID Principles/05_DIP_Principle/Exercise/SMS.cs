using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._05_DIP_Principle.Exercise
{
    public class SMS : ISMSMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
        }
    }
}
