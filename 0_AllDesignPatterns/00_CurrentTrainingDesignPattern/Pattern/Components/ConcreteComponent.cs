using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern.Components
{
    class ConcreteComponent : AbstractComponent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation");
        }
    }
}
