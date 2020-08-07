using _02_BuilderDesignPattern.HouseElement;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_BuilderDesignPattern.Pattern.PatternElementBuilder
{
    class ConcreteBuilder : Builder
    {
        House house = new House();
        public override void BuildBasement()
        {
            house.Add(new Basement());
        }

        public override void BuildRoof()
        {
            house.Add(new Roof());
        }

        public override void BuildStorey()
        {
            house.Add(new Storey());
        }

        public override House CreateHouse()
        {
            return house;
        }
    }
}
