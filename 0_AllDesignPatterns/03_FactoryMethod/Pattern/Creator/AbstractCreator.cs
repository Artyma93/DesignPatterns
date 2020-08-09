using _03_FactoryMethod.Pattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FactoryMethod.Pattern.Creator
{
   abstract class AbstractCreator
    {
        AbstractProduct product;

        public abstract AbstractProduct FactoryMethod();

        public void AnOperation()
        {
            product = FactoryMethod();
        }
    }
}
