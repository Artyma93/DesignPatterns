using System;
using System.Collections.Generic;
using System.Text;

namespace _06_AdapterDesignPattern_Object.Pattern
{
    class Adaptee
    {
        public void SpecificalRequest()
        {
            Console.WriteLine("Adaptee.SpecificalRequest");
        }
    }
}
