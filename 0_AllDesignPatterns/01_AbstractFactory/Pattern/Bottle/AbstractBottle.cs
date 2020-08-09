using _01_AbstractFactory.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactory.Pattern.Bottle
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
    }
}
