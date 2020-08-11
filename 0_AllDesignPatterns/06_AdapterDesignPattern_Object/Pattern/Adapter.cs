using System;
using System.Collections.Generic;
using System.Text;

namespace _06_AdapterDesignPattern_Object.Pattern
{
    class Adapter : Target
    {
        Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificReques();
        }
    }
}
