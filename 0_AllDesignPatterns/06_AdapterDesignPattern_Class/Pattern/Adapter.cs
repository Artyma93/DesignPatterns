using System;
using System.Collections.Generic;
using System.Text;

namespace _06_AdapterDesignPattern_Class.Pattern
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            base.SpecificRequest();
        }
    }
}
