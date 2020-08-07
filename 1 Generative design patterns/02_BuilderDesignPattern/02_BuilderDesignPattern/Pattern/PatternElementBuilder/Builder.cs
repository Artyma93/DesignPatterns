using _02_BuilderDesignPattern.HouseElement;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_BuilderDesignPattern.Pattern.PatternElementBuilder
{
    abstract class Builder
    {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract House CreateHouse();
    }
}
