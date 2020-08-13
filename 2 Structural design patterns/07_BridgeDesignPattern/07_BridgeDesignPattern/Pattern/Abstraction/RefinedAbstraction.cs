using _07_BridgeDesignPattern.Pattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_BridgeDesignPattern.Pattern.Abstraction
{
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(AbstractImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            // ...
            base.Operation();
            // ...
        }
    }
}
