using _03_FactoryMethod.Pattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FactoryMethod.Pattern.Creator
{
    class ConcreteCreator : AbstractCreator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
