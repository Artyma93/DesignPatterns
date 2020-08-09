using _02_Builder.HouseElement;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Builder.Pattern.Builder
{
    abstract class AbstractBuilder
    {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract House CreateHouse();
    }
}
