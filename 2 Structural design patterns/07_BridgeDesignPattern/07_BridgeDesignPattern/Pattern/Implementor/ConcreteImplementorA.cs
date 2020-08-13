using System;
using System.Collections.Generic;
using System.Text;

namespace _07_BridgeDesignPattern.Pattern.Implementor
{
    class ConcreteImplementorA : AbstractImplementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorA");
        }
    }
}
