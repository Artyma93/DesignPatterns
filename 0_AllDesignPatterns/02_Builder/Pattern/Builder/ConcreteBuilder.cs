using _02_Builder.HouseElement;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Builder.Pattern.Builder
{
    class ConcreteBuilder : AbstractBuilder
    {
        House house = new House();
        public override void BuildBasement()
        {
            house.Add(new Basement());
        }

        public override void BuildStorey()
        {
            house.Add(new Storey());
        }

        public override void BuildRoof()
        {
            house.Add(new Roof());
        }

        public override House CreateHouse()
        {
            return house;
        }
    }
}
