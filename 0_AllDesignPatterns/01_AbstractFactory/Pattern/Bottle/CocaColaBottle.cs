using _01_AbstractFactory.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactory.Pattern.Bottle
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(water);
        }
    }
}
