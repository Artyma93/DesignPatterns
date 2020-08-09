using _03_FactoryMethodDesignPattern.Pattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FactoryMethodDesignPattern.Pattern.Creators
{
    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
