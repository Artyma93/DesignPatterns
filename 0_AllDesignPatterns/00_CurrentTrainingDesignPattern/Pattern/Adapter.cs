using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    class Adapter : Target
    {
        Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
