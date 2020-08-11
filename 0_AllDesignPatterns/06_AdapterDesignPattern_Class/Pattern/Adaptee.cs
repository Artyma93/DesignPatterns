using System;
using System.Collections.Generic;
using System.Text;

namespace _06_AdapterDesignPattern_Class.Pattern
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee.SpecificRequest");
        }
    }
}
