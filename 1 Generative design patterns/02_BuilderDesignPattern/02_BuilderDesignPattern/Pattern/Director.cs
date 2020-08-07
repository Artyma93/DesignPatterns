using _02_BuilderDesignPattern.Pattern.PatternElementBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_BuilderDesignPattern.Pattern
{
    class Director
    {
        private readonly Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}
