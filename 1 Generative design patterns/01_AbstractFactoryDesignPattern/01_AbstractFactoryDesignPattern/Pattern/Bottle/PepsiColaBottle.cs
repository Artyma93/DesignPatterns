using _01_AbstractFactoryDesignPattern.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactoryDesignPattern.Pattern.Bottle
{
    class PepsiColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(water);
        }
    }
}
