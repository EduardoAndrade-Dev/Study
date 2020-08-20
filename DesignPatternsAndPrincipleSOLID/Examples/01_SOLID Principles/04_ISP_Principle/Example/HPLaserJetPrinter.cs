using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.SOLID_Principles._04_ISP_Principle.Example
{
    public class HPLaserJetPrinter: IFax, IPrint,IScan
    {
        public void Fax(string content)
        {
            Console.WriteLine(content);
        }

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }
    }
}
