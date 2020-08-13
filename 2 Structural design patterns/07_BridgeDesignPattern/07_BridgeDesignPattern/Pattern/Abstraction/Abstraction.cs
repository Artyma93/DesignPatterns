using _07_BridgeDesignPattern.Pattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_BridgeDesignPattern.Pattern.Abstraction
{
    abstract class Abstraction
    {
        AbstractImplementor implementor;
        public Abstraction(AbstractImplementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
