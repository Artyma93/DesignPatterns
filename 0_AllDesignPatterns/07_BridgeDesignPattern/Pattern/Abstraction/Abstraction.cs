using _07_BridgeDesignPattern.Pattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_BridgeDesignPattern.Pattern.Abstraction
{
    abstract class Abstraction
    {
        AbstractionImplementor implementor;
        public Abstraction(AbstractionImplementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
