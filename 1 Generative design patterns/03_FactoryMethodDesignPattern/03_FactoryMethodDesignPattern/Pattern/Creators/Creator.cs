using _03_FactoryMethodDesignPattern.Pattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FactoryMethodDesignPattern.Pattern.Creators
{
    abstract class Creator
    {
        Product product;

        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            product = FactoryMethod();
        }
    }
}
